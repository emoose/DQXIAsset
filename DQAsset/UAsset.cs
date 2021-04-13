using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DQAsset
{
    public class PackageFile
    {
        public static uint PACKAGE_FILE_TAG = 0x9E2A83C1;

        public static readonly Dictionary<string, Type> KnownTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                //.Where(t => t.GetInterfaces().Contains(typeof(ISerializable)))
                .Where(t => t.BaseType == typeof(FTableRowBase) || (t.BaseType != null && t.BaseType.BaseType == typeof(FTableRowBase)))
                .ToDictionary(t => t.Name);

        public PackageFileSummary Header;
        public List<NameEntry> Names;
        public List<ObjectImport> Imports;
        public List<ObjectExport> Exports;
        public List<int> PreloadDependencies;

        public List<AbstractExportObject> ExportObjects;
        public bool SkipPropertyDataLoad = false; // skips deserializing DT data, eg. if we're just loading this as base to apply CSV to

        public bool UexpWriteInProgress = false;
        public bool FNameCleanupInProgress = false;
        public List<Tuple<FName, long>> UExpFnames;

        public void DeserializeText(string text)
        {

            //var lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            text = text.Replace("\r\n", "\n");
            var firstLineEnd = text.IndexOf('\n');
            text = text.Substring(firstLineEnd + 1);

            foreach (var exp in ExportObjects)
            {
                // Remove any TextHeader lines from the input text
                // TODO: check against SerializeTextHeader value?

                exp.DeserializeText(text, this);
            }
        }

        public string SerializeText()
        {
            var retVal = "";
            foreach (var exp in ExportObjects)
            {
                retVal += exp.SerializeTextHeader(this);
                retVal += "\n";
                retVal += exp.SerializeText(this, true);
            }
            return retVal;
        }

        public void Deserialize(BinaryReader reader)
        {
            Header = new PackageFileSummary();
            Header.Deserialize(reader, this);

            reader.BaseStream.Position = Header.NameOffset;
            Names = new List<NameEntry>();
            for (int i = 0; i < Header.NameCount; i++)
            {
                var entry = new NameEntry();
                entry.Deserialize(reader, this);
                Names.Add(entry);
            }

            reader.BaseStream.Position = Header.ImportOffset;
            Imports = new List<ObjectImport>();
            for (int i = 0; i < Header.ImportCount; i++)
            {
                var imp = new ObjectImport();
                imp.Deserialize(reader, this);
                Imports.Add(imp);
            }

            reader.BaseStream.Position = Header.ExportOffset;
            Exports = new List<ObjectExport>();
            for (int i = 0; i < Header.ExportCount; i++)
            {
                var exp = new ObjectExport();
                exp.Deserialize(reader, this);
                Exports.Add(exp);
            }

            // 8 bytes pointed to by DependsOffset: 00 00 00 00 00 00 00 00

            reader.BaseStream.Position = Header.PreloadDependencyOffset;
            PreloadDependencies = new List<int>();
            for (int i = 0; i < Header.PreloadDependencyCount; i++)
            {
                PreloadDependencies.Add(reader.ReadInt32());
            }

            ExportObjects = new List<AbstractExportObject>();
            foreach (var exp in Exports)
            {
                reader.BaseStream.Position = exp.SerialOffset;
                var export = new AbstractExportObject();
                export.Deserialize(reader, this);
                ExportObjects.Add(export);
            }

            if (!SkipPropertyDataLoad)
                if (reader.BaseStream.Position != (reader.BaseStream.Length - 4))
                    throw new Exception("Failed to fully deserialize UAsset");
        }

        bool isSecondPass = false;

        public void Serialize(BinaryWriter uexp, BinaryWriter uasset, bool doFnameCleanup)
        {
            // Set flag to make FName::Serialize add itself to a list
            // This way we can update all FNames later without needing to do another whole serialization pass
            FNameCleanupInProgress = doFnameCleanup;
            if (doFnameCleanup)
            {
                isSecondPass = false;
                UExpFnames = new List<Tuple<FName, long>>();
            }

            // Write out export data first
            if (uexp != null && !isSecondPass)
            {
                var uexpPosition = uexp.BaseStream.Position;

                if (doFnameCleanup)
                    foreach (var entry in Names)
                        entry.InUse = false;

                UexpWriteInProgress = true;
                for (int i = 0; i < Exports.Count; i++)
                {
                    var expPosition = uexp.BaseStream.Position;

                    var exportHeader = Exports[i];
                    var exportData = ExportObjects[i];

                    exportHeader.SerialOffset = uexp.BaseStream.Position - uexpPosition;
                    exportData.Serialize(uexp, this);

                    exportHeader.SerialSize = uexp.BaseStream.Position - expPosition;
                }

                uexp.Write(PACKAGE_FILE_TAG);
            }

            // Don't allow uasset header FNames to add to UExpFnames
            UexpWriteInProgress = false;

            // Header.Generations seems to contain NameCount/ExportCount that matches header
            // Check if any match the existing data, and choose that as the generation to update
            int updateGenerationIdx = -1;
            if (Header.Generations.Count > 0)
            {
                for (int i = 0; i < Header.Generations.Count; i++)
                {
                    var gen = Header.Generations[i];
                    if (gen.NameCount == Header.NameCount && gen.ExportCount == Header.ExportCount)
                    {
                        updateGenerationIdx = i;
                        break;
                    }
                }
            }

            // Update header
            Header.NameCount = Names.Count;
            Header.ImportCount = Imports.Count;
            Header.ExportCount = Exports.Count;

            if (updateGenerationIdx >= 0)
            {
                var gen = Header.Generations[updateGenerationIdx];
                gen.ExportCount = Header.ExportCount;
                gen.NameCount = Header.NameCount;
            }

            if(Header.IsVersionOrGreater(UE4Versions.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
                Header.PreloadDependencyCount = PreloadDependencies.Count;

            // Write header (will get rewritten later with updated offsets etc)
            var headerPosition = uasset.BaseStream.Position;
            Header.Serialize(uasset, this);

            Header.NameOffset = (int)(uasset.BaseStream.Position - headerPosition);
            foreach (var name in Names)
                name.Serialize(uasset, this);

            Header.ImportOffset = (int)(uasset.BaseStream.Position - headerPosition);
            foreach (var imp in Imports)
                imp.Serialize(uasset, this);

            Header.ExportOffset = (int)(uasset.BaseStream.Position - headerPosition);
            foreach (var exp in Exports)
                exp.Serialize(uasset, this);

            // TODO: should we be handling the Depends stuff properly?
            Header.DependsOffset = (int)(uasset.BaseStream.Position - headerPosition);
            for (int i = 0; i < Exports.Count; i++)
                uasset.Write(0);

            Header.AssetRegistryDataOffset = (int)(uasset.BaseStream.Position - headerPosition);
            uasset.Write(0);

            if (Header.IsVersionOrGreater(UE4Versions.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                Header.PreloadDependencyOffset = (int)(uasset.BaseStream.Position - headerPosition);
                foreach (var preloadDep in PreloadDependencies)
                    uasset.Write(preloadDep);
            }

            Header.TotalHeaderSize = (int)(uasset.BaseStream.Position - headerPosition);

            // Write updated section offsets/sizes to header:
            uasset.BaseStream.Position = headerPosition;
            Header.Serialize(uasset, this);

            // Update export objects with proper SerialOffset
            // TODO: figure out why this wasn't needed previously!
            uasset.BaseStream.Position = headerPosition + Header.ExportOffset;
            foreach (var exp in Exports)
            {
                exp.SerialOffset += Header.TotalHeaderSize;
                exp.Serialize(uasset, this);
            }

            if (doFnameCleanup)
            {
                var notInUseFNameIndexes = new List<int>();

                // Process the indexes in reverse order so indexes remain valid during the RemoveAt foreach
                for (int i = Names.Count - 1; i >= 0; i--)
                    if (!Names[i].InUse)
                        if (!Names[i].Name.StartsWith("/Game/") && Names[i].Name != "UserDefinedStruct") // some reason these isn't referenced by any FName in the file, make sure to exclude it...
                            notInUseFNameIndexes.Add(i);

                // Some FNames are part of a larger FName, smaller one isn't referenced but I guess is important since it exists...
                // Check if any to-be-removed FNames are part of something larger
                for (int i = notInUseFNameIndexes.Count - 1; i >= 0; i--)
                {
                    var name = Names[notInUseFNameIndexes[i]].Name;
                    bool removeFromList = false;
                    for (int y = 0; y < Names.Count; y++)
                    {
                        if (!notInUseFNameIndexes.Contains(y))
                            if (Names[y].Name.StartsWith(name))
                            {
                                removeFromList = true;
                                break;
                            }
                    }
                    if (removeFromList)
                        notInUseFNameIndexes.RemoveAt(i);
                }

                FNameCleanupInProgress = false;

                if (notInUseFNameIndexes.Count <= 0)
                    return; // no cleanup needed

                // debug:
                /*var notInUse = new List<string>();
                foreach (var idx in notInUseFNameIndexes)
                    notInUse.Add(Names[idx].Name);*/

                // Remove not in use entries
                foreach (var idx in notInUseFNameIndexes)
                    Names.RemoveAt(idx);

                // Update FName indexes inside uexp
                foreach (var name in UExpFnames)
                {
                    uexp.BaseStream.Position = name.Item2;
                    name.Item1.Serialize(uexp, this);
                }

                // Remove uasset header size from Exports SerialOffset (second pass will add the updated header size)
                foreach (var exp in Exports)
                {
                    exp.SerialOffset -= Header.TotalHeaderSize;
                }

                // Need to do second header serialization pass so that updated Names array/indexes are written
                uasset.BaseStream.Position = headerPosition;
                uasset.BaseStream.SetLength(0);
                isSecondPass = true;
                Serialize(null, uasset, false);
                isSecondPass = false;
            }
        }
    }

    public class NameEntry : ISerializable
    {
        public string Name;
        public ushort NonCasePreservingHash;
        public ushort CasePreservingHash;

        public bool InUse; // set/reset during serialization so we can tell any unused entries

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Name = reader.ReadFString();
            if (!package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_NAME_HASHES_SERIALIZED))
                return;

            NonCasePreservingHash = reader.ReadUInt16();
            CasePreservingHash = reader.ReadUInt16();
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            writer.WriteFString(Name);

            if (!package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_NAME_HASHES_SERIALIZED))
                return;

            if (Shared.HasNonASCIIChars(Name))
            {
                NonCasePreservingHash = (ushort)(Shared.UE4Strihash_DEPRECATED_Wide(Name) & 0xFFFF);
                CasePreservingHash = (ushort)(Shared.UE4StrCrc32_Wide(Name) & 0xFFFF);
            }
            else
            {
                NonCasePreservingHash = (ushort)(Shared.UE4Strihash_DEPRECATED(Name) & 0xFFFF);
                CasePreservingHash = (ushort)(Shared.UE4StrCrc32(Name) & 0xFFFF);
            }

            writer.Write(NonCasePreservingHash);
            writer.Write(CasePreservingHash);
        }

        public override string ToString() => Name;
    }

    public class FName : ISerializable
    {
        public int Index = 0;
        public int InstanceNum = 0;

        public string Value;

        public FName() { }

        public FName(string value)
        {
            Value = value;
            TryGetInstanceNum();
        }

        void TryGetInstanceNum()
        {
            // Convert FName that contains InstanceNum (eg. W_WPN++2048++) into InstanceNum + Value
            if (!Value.EndsWith("++"))
                return;

            var numEndIdx = Value.LastIndexOf("++");
            var numStartIdx = Value.LastIndexOf("++", numEndIdx);
            if (numStartIdx >= 0 && numEndIdx >= numStartIdx)
            {
                var instanceNum = Value.Substring(numStartIdx + 2, numEndIdx - (numStartIdx + 2));
                InstanceNum = int.Parse(instanceNum);
                Value = Value.Substring(0, numStartIdx);
            }
        }

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Index = reader.ReadInt32();
            InstanceNum = reader.ReadInt32();

            if (package.Names.Count > Index && Index >= 0)
                Value = package.Names[Index].Name;
            else
                throw new Exception("Deserialized FName not found in UAsset header?");
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            TryGetInstanceNum();

            Index = package.Names.FindIndex(s => s.Name == Value);
            if (Index == -1)
            {
                var ent = new NameEntry();
                ent.Name = Value;
                package.Names.Add(ent);
                Index = package.Names.FindIndex(s => s.Name == Value);
                if (Index == -1)
                    throw new Exception("Failed to add new FName for some reason!");
            }

            if (package.FNameCleanupInProgress)
            {
                package.Names[Index].InUse = true;
                if (package.UexpWriteInProgress)
                    package.UExpFnames.Add(new Tuple<FName, long>(this, writer.BaseStream.Position));
            }

            writer.Write(Index);
            writer.Write(InstanceNum);
        }

        public override string ToString()
        {
            if (InstanceNum == 0)
                return Value;
            return $"{Value}++{InstanceNum}++";
        }

        public override bool Equals(object? other)
        {
            if (other == null && this == null)
                return true;
            if (other.GetType() != GetType())
                return false;
            var otherName = other as FName;

            otherName.TryGetInstanceNum();
            TryGetInstanceNum();

            return otherName.Value == this.Value && otherName.InstanceNum == this.InstanceNum;
        }
    }

    public class PackageIndex : ISerializable
    {
        public int Index;

        public ObjectImport ImportObject;
        public ObjectExport ExportObject;

        public bool IsImport() => Index < 0;
        public bool IsExport() => Index > 0;
        public bool IsNull() => Index == 0;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Index = reader.ReadInt32();

            int importIndex = (-Index) - 1;
            int exportIndex = Index - 1;

            if (IsImport() && package.Imports.Count > importIndex)
                ImportObject = package.Imports[importIndex];
            if (IsExport() && package.Exports.Count > exportIndex)
                ExportObject = package.Exports[exportIndex];
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            // TODO: update Index with index of this package import/export
            writer.Write(Index);
        }
    }

    public class ObjectImport : ISerializable
    {
        public FName ClassPackage;
        public FName ClassName;
        public PackageIndex PackageRef;
        public FName ObjectName;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            ClassPackage = new FName();
            ClassPackage.Deserialize(reader, package);
            ClassName = new FName();
            ClassName.Deserialize(reader, package);
            PackageRef = new PackageIndex();
            PackageRef.Deserialize(reader, package);
            ObjectName = new FName();
            ObjectName.Deserialize(reader, package);
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            ClassPackage.Serialize(writer, package);
            ClassName.Serialize(writer, package);
            PackageRef.Serialize(writer, package);
            ObjectName.Serialize(writer, package);
        }
    }

    public class ObjectExport : ISerializable
    {
        public PackageIndex ClassIndex;
        public PackageIndex SuperIndex;
        public PackageIndex TemplateIndex;
        public PackageIndex OuterIndex;
        public FName ObjectName;
        public uint ObjectFlags;
        public long SerialSize;
        public long SerialOffset;
        public int bForcedExport;
        public int bNotForClient;
        public int bNotForServer;
        public byte[] PackageGuid;
        public uint PackageFlags;
        public int bNotAlwaysLoadedForEditorGame;
        public int bIsAsset;
        public int FirstExportDependency;
        public int SerializationBeforeSerializationDependencies;
        public int CreateBeforeSerializationDependencies;
        public int SerializationBeforeCreateDependencies;
        public int CreateBeforeCreateDependencies;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            ClassIndex = new PackageIndex();
            ClassIndex.Deserialize(reader, package);
            SuperIndex = new PackageIndex();
            SuperIndex.Deserialize(reader, package);

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS))
            {
                TemplateIndex = new PackageIndex();
                TemplateIndex.Deserialize(reader, package);
            }

            OuterIndex = new PackageIndex();
            OuterIndex.Deserialize(reader, package);

            ObjectName = new FName();
            ObjectName.Deserialize(reader, package);

            ObjectFlags = reader.ReadUInt32();

            SerialSize = package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES) ? reader.ReadInt64() : reader.ReadInt32();
            SerialOffset = package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES) ? reader.ReadInt64() : reader.ReadInt32();

            bForcedExport = reader.ReadInt32();
            bNotForClient = reader.ReadInt32();
            bNotForServer = reader.ReadInt32();

            PackageGuid = reader.ReadBytes(0x10);
            PackageFlags = reader.ReadUInt32();

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_LOAD_FOR_EDITOR_GAME))
                bNotAlwaysLoadedForEditorGame = reader.ReadInt32();

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT))
                bIsAsset = reader.ReadInt32();

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                FirstExportDependency = reader.ReadInt32();
                SerializationBeforeSerializationDependencies = reader.ReadInt32();
                CreateBeforeSerializationDependencies = reader.ReadInt32();
                SerializationBeforeCreateDependencies = reader.ReadInt32();
                CreateBeforeCreateDependencies = reader.ReadInt32();
            }
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            ClassIndex.Serialize(writer, package);
            SuperIndex.Serialize(writer, package);
            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS))
                TemplateIndex.Serialize(writer, package);
            OuterIndex.Serialize(writer, package);

            ObjectName.Serialize(writer, package);
            writer.Write(ObjectFlags);

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES))
                writer.Write(SerialSize);
            else
                writer.Write((int)SerialSize);

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES))
                writer.Write(SerialOffset);
            else
                writer.Write((int)SerialOffset);

            writer.Write(bForcedExport);
            writer.Write(bNotForClient);
            writer.Write(bNotForServer);
            writer.Write(PackageGuid);
            writer.Write(PackageFlags);

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_LOAD_FOR_EDITOR_GAME))
                writer.Write(bNotAlwaysLoadedForEditorGame);

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT))
                writer.Write(bIsAsset);

            if (package.Header.IsVersionOrGreater(UE4Versions.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                writer.Write(FirstExportDependency);
                writer.Write(SerializationBeforeSerializationDependencies);
                writer.Write(CreateBeforeSerializationDependencies);
                writer.Write(SerializationBeforeCreateDependencies);
                writer.Write(CreateBeforeCreateDependencies);
            }
        }
    }

    public class PropertyTag : ISerializable
    {
        public FName Name;
        public FName Type;
        public int Size;
        public int Index;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Name = new FName();
            Name.Deserialize(reader, package);
            Type = new FName();
            Type.Deserialize(reader, package);
            Size = reader.ReadInt32();
            Index = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            Name.Serialize(writer, package);
            Type.Serialize(writer, package);
            writer.Write(Size);
            writer.Write(Index);
        }
    }

    public class PropertyGuid : ISerializable
    {
        public byte HasGuid;
        public byte[] Guid;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            HasGuid = reader.ReadByte();
            if (HasGuid != 0)
                Guid = reader.ReadBytes(0x10);
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            HasGuid = (byte)(Guid != null ? 1 : 0);
            writer.Write(HasGuid);
            if (Guid != null)
                writer.Write(Guid);
        }
    }

    public class ObjectProperty : FTableRowBase
    {
        public PropertyGuid Guid;
        public PackageIndex Value;
        public override void Deserialize(BinaryReader reader, PackageFile package)
        {
            Guid = new PropertyGuid();
            Guid.Deserialize(reader, package);
            Value = new PackageIndex();
            Value.Deserialize(reader, package);
        }

        public override void Serialize(BinaryWriter writer, PackageFile package)
        {
            Guid.Serialize(writer, package);
            Value.Serialize(writer, package);
        }
    }

    public class AbstractExportObject : ISerializableText
    {
        public List<PropertyTag> PropertyTags;
        public List<ISerializable> Properties;
        public uint Reserved;
        public Dictionary<FName, ISerializableText> PropertiesData;

        public string SerializeTextHeader(PackageFile package)
        {
            if (PropertiesData == null || PropertiesData.Count <= 0)
                return null;

            return "RowName," + PropertiesData.First().Value.SerializeTextHeader(package);
        }
        public string SerializeText(PackageFile package, bool isMainElement)
        {
            // TODO: add a CSV header line from the type in PropertiesData?

            string[] lines = new string[PropertiesData.Count];
            int i = 0;
            foreach (var kvp in PropertiesData)
            {
                lines[i] = $"{kvp.Key},{kvp.Value.SerializeText(package, isMainElement)}";
                i++;
            }

            return String.Join('\n', lines);
        }

        public void DeserializeText(string text, PackageFile package)
        {
            Type? rowType = null;
            foreach (var prop in Properties)
            {
                if (prop.GetType() != typeof(ObjectProperty))
                    continue;

                var objectProperty = prop as ObjectProperty;
                if (!PackageFile.KnownTypes.TryGetValue(objectProperty.Value.ImportObject.ObjectName.Value, out rowType))
                    if (!PackageFile.KnownTypes.TryGetValue("F" + objectProperty.Value.ImportObject.ObjectName.Value, out rowType))
                        throw new Exception($"UAsset uses unknown struct type {objectProperty.Value.ImportObject.ObjectName.Value}!");

                break; // probably shouldn't be doing this, hopefully all DQXI tables only contain a single ObjectProperty...
            }

            if (rowType == null)
                throw new Exception("Failed to find rowType type!");

            text = text.Replace("\r\n", "\n");

            var lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                // Read + remove RowName from the line
                var rowNameEndIdx = line.IndexOf(',');
                var key = line.Substring(0, rowNameEndIdx);
                var value = line.Substring(rowNameEndIdx + 1);

                var keyFName = new FName(key);
                ISerializableText rowValue;
                if (PropertiesData.ContainsKey(keyFName))
                    rowValue = PropertiesData[keyFName];
                else
                    rowValue = Activator.CreateInstance(rowType) as ISerializableText;

                rowValue.DeserializeText(value, package);

                PropertiesData[keyFName] = rowValue;
            }
            // TODO load values from text into class
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            for (int i = 0; i < PropertyTags.Count; i++)
            {
                var tag = PropertyTags[i];
                ISerializable property = null;
                if (Properties.Count >= i)
                    property = Properties[i];

                tag.Serialize(writer, package);
                if (property != null)
                    property.Serialize(writer, package);
            }
            var endName = new FName();
            endName.Value = "None";
            endName.Serialize(writer, package);

            writer.Write(Reserved);

            foreach (var prop in Properties)
            {
                if (prop.GetType() != typeof(ObjectProperty))
                    continue;

                writer.Write(PropertiesData.Count);

                foreach (var kvp in PropertiesData)
                {
                    kvp.Key.Serialize(writer, package);

                    bool writeStructSize = true;
                    var settings = kvp.Value.GetType().GetCustomAttribute<SerializerAttribute>();
                    if (settings != null && settings.NoStructSize)
                        writeStructSize = false;

                    long structSizePosition = 0;

                    if (writeStructSize)
                    {
                        structSizePosition = writer.BaseStream.Position;
                        writer.Write((int)0);// dummy val, we'll fix it later
                    }

                    var structStartPosition = writer.BaseStream.Position;
                    kvp.Value.Serialize(writer, package);
                    var structEndPosition = writer.BaseStream.Position;

                    if (writeStructSize)
                    {
                        var structSize = structEndPosition - structStartPosition;
                        writer.BaseStream.Position = structSizePosition;
                        writer.Write((uint)structSize);
                        writer.BaseStream.Position = structEndPosition;
                    }
                }
            }
        }

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            PropertyTags = new List<PropertyTag>();
            Properties = new List<ISerializable>();
            while (true)
            {
                var pos = reader.BaseStream.Position;
                var name = new FName();
                name.Deserialize(reader, package);
                if (name.Value == "None")
                    break;

                reader.BaseStream.Position = pos;

                var tag = new PropertyTag();
                tag.Deserialize(reader, package);
                PropertyTags.Add(tag);

                Type? propertyType;
                if (!PackageFile.KnownTypes.TryGetValue(tag.Type.Value, out propertyType))
                    if (!PackageFile.KnownTypes.TryGetValue("F" + tag.Type.Value, out propertyType))
                        throw new Exception($"UAsset uses unknown struct type {tag.Type.Value}!");

                var prop = Activator.CreateInstance(propertyType) as ISerializable;
                prop.Deserialize(reader, package);
                Properties.Add(prop);
            }
            Reserved = reader.ReadUInt32();

            // ObjectProperty data comes after the properties/propertytags section
            // I don't know if any other properties are handled this way, probably not, doing this is likely wrong for 99% of other UE4 properties

            PropertiesData = new Dictionary<FName, ISerializableText>();
            foreach (var prop in Properties)
            {
                if (prop.GetType() != typeof(ObjectProperty))
                    continue;

                var objectProperty = prop as ObjectProperty;

                Type? propertyType;
                if (!PackageFile.KnownTypes.TryGetValue(objectProperty.Value.ImportObject.ObjectName.Value, out propertyType))
                    if (!PackageFile.KnownTypes.TryGetValue("F" + objectProperty.Value.ImportObject.ObjectName.Value, out propertyType))
                        throw new Exception($"UAsset uses unknown struct type {objectProperty.Value.ImportObject.ObjectName.Value}!");

                if (propertyType == typeof(FJackDataTableNativizationAsset) || propertyType == typeof(FJackDataTableBlueprintClass))
                    Program.DoFNameCleanup = false; // contains a bunch of unreferenced FNames, can't cleanup properly :(

                if (package.SkipPropertyDataLoad)
                    continue;

                int count = reader.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    var rowName = new FName();
                    rowName.Deserialize(reader, package);

                    var position = reader.BaseStream.Position;
                    if (propertyType.BaseType.GetInterfaces().Contains(typeof(ISerializableText)))
                    {
                        int structSize = 0;
                        var settings = propertyType.GetCustomAttribute<SerializerAttribute>();
                        if (settings == null || !settings.NoStructSize)
                        {
                            structSize = reader.ReadInt32();
                            position = reader.BaseStream.Position;
                        }

                        var propData = Activator.CreateInstance(propertyType) as ISerializableText;
                        propData.Deserialize(reader, package);

                        var length = reader.BaseStream.Position - position;
                        if (structSize != 0 && length != structSize)
                        {
                            throw new Exception($"DataTable read incorrect number of bytes (read {length}, expected {structSize}!)");
                            reader.BaseStream.Position = position + structSize;
                        }

                        PropertiesData.Add(rowName, propData);
                    }
                }
            }
        }
    }

    public class FEngineVersion : ISerializable
    {
        public ushort Major;
        public ushort Minor;
        public ushort Patch;
        public uint Changelist;
        public string Branch;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Major = reader.ReadUInt16();
            Minor = reader.ReadUInt16();
            Patch = reader.ReadUInt16();
            Changelist = reader.ReadUInt32();
            Branch = reader.ReadFString();
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            writer.Write(Major);
            writer.Write(Minor);
            writer.Write(Patch);
            writer.Write(Changelist);
            writer.WriteFString(Branch);
        }
    }
}
