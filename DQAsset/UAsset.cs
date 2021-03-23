using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DQAsset
{
    public struct GenerationInfo
    {
        public int ExportCount;
        public int NameCount;
    }

    public struct EngineVersion
    {
        public uint Major;
        public uint Minor;
        public uint Patch;
        public uint Changeset;
    }

    public struct CompressedChunk
    {
        public int UncompressedOffset;
        public int UncompressedSize;
        public int CompressedOffset;
        public int CompressedSize;
    }

    public class NameEntry : ISerializable
    {
        public string Name;
        public ushort NonCasePreservingHash;
        public ushort CasePreservingHash;

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Name = reader.ReadFString();
            NonCasePreservingHash = reader.ReadUInt16();
            CasePreservingHash = reader.ReadUInt16();
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            writer.WriteFString(Name);

            NonCasePreservingHash = (ushort)(Shared.UE4Strihash_DEPRECATED(Name) & 0xFFFF);
            CasePreservingHash = (ushort)(Shared.UE4StrCrc32(Name) & 0xFFFF);

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
        public int ForcedExport;
        public int NotForClient;
        public int NotForServer;
        public byte[] PackageGuid;
        public uint PackageFlags;
        public int NotAlwaysLoadedForEditorGame;
        public int IsAsset;
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
            TemplateIndex = new PackageIndex();
            TemplateIndex.Deserialize(reader, package);
            OuterIndex = new PackageIndex();
            OuterIndex.Deserialize(reader, package);

            ObjectName = new FName();
            ObjectName.Deserialize(reader, package);
            ObjectFlags = reader.ReadUInt32();

            SerialSize = package.Header.FileVersionUE4 >= 511 ? reader.ReadInt64() : reader.ReadInt32();
            SerialOffset = package.Header.FileVersionUE4 >= 511 ? reader.ReadInt64() : reader.ReadInt32();

            ForcedExport = reader.ReadInt32();
            NotForClient = reader.ReadInt32();
            NotForServer = reader.ReadInt32();

            PackageGuid = reader.ReadBytes(0x10);
            PackageFlags = reader.ReadUInt32();

            NotAlwaysLoadedForEditorGame = reader.ReadInt32();
            IsAsset = reader.ReadInt32();
            FirstExportDependency = reader.ReadInt32();
            SerializationBeforeSerializationDependencies = reader.ReadInt32();
            CreateBeforeSerializationDependencies = reader.ReadInt32();
            SerializationBeforeCreateDependencies = reader.ReadInt32();
            CreateBeforeCreateDependencies = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            ClassIndex.Serialize(writer, package);
            SuperIndex.Serialize(writer, package);
            TemplateIndex.Serialize(writer, package);
            OuterIndex.Serialize(writer, package);

            ObjectName.Serialize(writer, package);
            writer.Write(ObjectFlags);

            if (package.Header.FileVersionUE4 >= 511)
                writer.Write(SerialSize);
            else
                writer.Write((int)SerialSize);

            if (package.Header.FileVersionUE4 >= 511)
                writer.Write(SerialOffset);
            else
                writer.Write((int)SerialOffset);

            writer.Write(ForcedExport);
            writer.Write(NotForClient);
            writer.Write(NotForServer);
            writer.Write(PackageGuid);
            writer.Write(PackageFlags);

            writer.Write(NotAlwaysLoadedForEditorGame);
            writer.Write(IsAsset);
            writer.Write(FirstExportDependency);
            writer.Write(SerializationBeforeSerializationDependencies);
            writer.Write(CreateBeforeSerializationDependencies);
            writer.Write(SerializationBeforeCreateDependencies);
            writer.Write(CreateBeforeCreateDependencies);
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
        public new void Deserialize(BinaryReader reader, PackageFile package)
        {
            Guid = new PropertyGuid();
            Guid.Deserialize(reader, package);
            Value = new PackageIndex();
            Value.Deserialize(reader, package);
        }

        public new void Serialize(BinaryWriter writer, PackageFile package)
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
            var retVal = "";

            // TODO: add a CSV header line from the type in PropertiesData?

            foreach (var kvp in PropertiesData)
            {
                retVal += kvp.Key.ToString() + ",";
                retVal += kvp.Value.SerializeText(package, isMainElement);
                retVal += Environment.NewLine;
            }

            return retVal;
        }

        public void DeserializeText(string text, PackageFile package)
        {
            Type? rowType = null;
            foreach (var prop in Properties)
            {
                if (prop.GetType() != typeof(ObjectProperty))
                    continue;

                var objectProperty = prop as ObjectProperty;
                if(!PackageFile.KnownTypes.TryGetValue(objectProperty.Value.ImportObject.ObjectName.Value, out rowType))
                    throw new Exception($"UAsset uses unknown struct type {objectProperty.Value.ImportObject.ObjectName.Value}!");

                break; // probably shouldn't be doing this, hopefully all DQXI tables only contain a single ObjectProperty...
            }

            if (rowType == null)
                throw new Exception("Failed to find rowType type!");

            var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach(var line in lines)
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

                int count = reader.ReadInt32();

                Type? propertyType;
                if (!PackageFile.KnownTypes.TryGetValue(objectProperty.Value.ImportObject.ObjectName.Value, out propertyType))
                    throw new Exception($"UAsset uses unknown struct type {objectProperty.Value.ImportObject.ObjectName.Value}!");

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

    public class PackageFileSummary : ISerializable
    {
        public uint Tag;
        public int LegacyFileVersion;
        public int LegacyUE3Version;
        public int FileVersionUE4;
        public int FileVersionLicenseeUE4;
        public int CustomVersionCount;
        public List<int> CustomVersion;
        public int TotalHeaderSize;
        public string FolderName;
        public uint PackageFlags;
        public int NameCount;
        public int NameOffset;
        public string LocalizationId;
        public int GatherableNameCount;
        public int GatherableNameOffset;
        public int ExportCount;
        public int ExportOffset;
        public int ImportCount;
        public int ImportOffset;
        public int DependsOffset;
        public int SoftPackageReferencesCount;
        public int SoftPackageReferencesOffset;
        public int SearchableNamesOffset;
        public int ThumbnailTableOffset;
        public byte[] Guid;

        public byte[] PersistentGuid;
        public byte[] OwnerPersistentGuid;

        public int GenerationCount;
        public List<GenerationInfo> Generations;

        public EngineVersion SavedByEngineVersion;
        public EngineVersion CompatibleWithEngineVersion;

        public int CompressedChunkCount;
        public List<CompressedChunk> CompressedChunks;

        public uint PackageSource;

        public int AdditionalPackagesToCookCount;
        public List<string> AdditionalPackagesToCook;

        public int NumTextureAllocations;
        public int AssetRegistryDataOffset;
        public long BulkDataStartOffset;
        public int WorldTileInfoDataOffset;

        public int ChunkIdCount;
        public List<int> ChunkIds;

        public int PreloadDependencyCount;
        public int PreloadDependencyOffset;

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            writer.Write(Tag);
            writer.Write(LegacyFileVersion);
            writer.Write(LegacyUE3Version);
            writer.Write(FileVersionUE4);
            writer.Write(FileVersionLicenseeUE4);

            CustomVersionCount = CustomVersion.Count;
            writer.Write(CustomVersionCount);
            foreach (var customVersion in CustomVersion)
                writer.Write(customVersion);

            writer.Write(TotalHeaderSize);
            writer.WriteFString(FolderName);

            writer.Write(PackageFlags);
            writer.Write(NameCount);
            writer.Write(NameOffset);

            if (FileVersionUE4 >= 516)
                writer.WriteFString(LocalizationId);

            writer.Write(GatherableNameCount);
            writer.Write(GatherableNameOffset);
            writer.Write(ExportCount);
            writer.Write(ExportOffset);
            writer.Write(ImportCount);
            writer.Write(ImportOffset);
            writer.Write(DependsOffset);
            writer.Write(SoftPackageReferencesCount);
            writer.Write(SoftPackageReferencesOffset);
            writer.Write(SearchableNamesOffset);
            writer.Write(ThumbnailTableOffset);
            writer.Write(Guid);
            if (FileVersionUE4 >= 518)
            {
                writer.Write(PersistentGuid);
                writer.Write(OwnerPersistentGuid);
            }

            GenerationCount = Generations.Count;
            writer.Write(GenerationCount);
            foreach (var gen in Generations)
                writer.WriteStruct(gen);

            writer.WriteStruct(SavedByEngineVersion);
            writer.WriteStruct(CompatibleWithEngineVersion);

            CompressedChunkCount = CompressedChunks.Count;
            writer.Write(CompressedChunkCount);
            foreach (var chunk in CompressedChunks)
                writer.WriteStruct(chunk);

            writer.Write(PackageSource);

            AdditionalPackagesToCookCount = AdditionalPackagesToCook.Count;
            writer.Write(AdditionalPackagesToCookCount);
            foreach (var addtPkg in AdditionalPackagesToCook)
                writer.WriteFString(addtPkg);

            if (LegacyFileVersion > -7)
                writer.Write(NumTextureAllocations);

            writer.Write(AssetRegistryDataOffset);
            writer.Write(BulkDataStartOffset);
            writer.Write(WorldTileInfoDataOffset);

            ChunkIdCount = ChunkIds.Count;
            writer.Write(ChunkIdCount);
            foreach (var chunk in ChunkIds)
                writer.Write(chunk);

            writer.Write(PreloadDependencyCount);
            writer.Write(PreloadDependencyOffset);
        }

        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            Tag = reader.ReadUInt32();
            LegacyFileVersion = reader.ReadInt32();
            LegacyUE3Version = reader.ReadInt32();
            FileVersionUE4 = reader.ReadInt32();
            FileVersionLicenseeUE4 = reader.ReadInt32();

            CustomVersionCount = reader.ReadInt32();
            CustomVersion = new List<int>();
            for (int i = 0; i < CustomVersionCount; i++)
                CustomVersion.Add(reader.ReadInt32());

            TotalHeaderSize = reader.ReadInt32();
            FolderName = reader.ReadFString();

            PackageFlags = reader.ReadUInt32();
            NameCount = reader.ReadInt32();
            NameOffset = reader.ReadInt32();

            if (FileVersionUE4 >= 516)
                LocalizationId = reader.ReadFString();

            GatherableNameCount = reader.ReadInt32();
            GatherableNameOffset = reader.ReadInt32();
            ExportCount = reader.ReadInt32();
            ExportOffset = reader.ReadInt32();
            ImportCount = reader.ReadInt32();
            ImportOffset = reader.ReadInt32();
            DependsOffset = reader.ReadInt32();
            SoftPackageReferencesCount = reader.ReadInt32();
            SoftPackageReferencesOffset = reader.ReadInt32();
            SearchableNamesOffset = reader.ReadInt32();
            ThumbnailTableOffset = reader.ReadInt32();
            Guid = reader.ReadBytes(0x10);
            if (FileVersionUE4 >= 518)
            {
                PersistentGuid = reader.ReadBytes(0x10);
                OwnerPersistentGuid = reader.ReadBytes(0x10);
            }

            GenerationCount = reader.ReadInt32();
            Generations = new List<GenerationInfo>();
            for (int i = 0; i < GenerationCount; i++)
                Generations.Add(reader.ReadStruct<GenerationInfo>());

            SavedByEngineVersion = reader.ReadStruct<EngineVersion>();
            CompatibleWithEngineVersion = reader.ReadStruct<EngineVersion>();

            CompressedChunkCount = reader.ReadInt32();
            CompressedChunks = new List<CompressedChunk>();
            for (int i = 0; i < CompressedChunkCount; i++)
                CompressedChunks.Add(reader.ReadStruct<CompressedChunk>());

            PackageSource = reader.ReadUInt32();
            AdditionalPackagesToCookCount = reader.ReadInt32();
            AdditionalPackagesToCook = new List<string>();
            for (int i = 0; i < AdditionalPackagesToCookCount; i++)
                AdditionalPackagesToCook.Add(reader.ReadFString());

            if (LegacyFileVersion > -7)
                NumTextureAllocations = reader.ReadInt32();

            AssetRegistryDataOffset = reader.ReadInt32();
            BulkDataStartOffset = reader.ReadInt64();
            WorldTileInfoDataOffset = reader.ReadInt32();
            ChunkIdCount = reader.ReadInt32();
            ChunkIds = new List<int>();
            for (int i = 0; i < ChunkIdCount; i++)
                ChunkIds.Add(reader.ReadInt32());

            PreloadDependencyCount = reader.ReadInt32();
            PreloadDependencyOffset = reader.ReadInt32();
        }
    }

    public class PackageFile
    {
        public static uint PACKAGE_FILE_TAG = 0x9E2A83C1;

        public static readonly Dictionary<string, Type> KnownTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                //.Where(t => t.GetInterfaces().Contains(typeof(ISerializable)))
                .Where(t => t.BaseType == typeof(FTableRowBase))
                .ToDictionary(t => t.Name);

        public PackageFileSummary Header;
        public List<NameEntry> Names;
        public List<ObjectImport> Imports;
        public List<ObjectExport> Exports;
        public List<int> PreloadDependencies;

        public List<AbstractExportObject> ExportObjects;

        public string SerializeText()
        {
            var retVal = "";
            foreach (var exp in ExportObjects)
            {
                retVal += exp.SerializeTextHeader(this);
                retVal += Environment.NewLine;
                retVal += exp.SerializeText(this, true);
            }
            return retVal;
        }

        public void DeserializeText(string text)
        {
            var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var exp in ExportObjects)
            {
                // Remove any TextHeader lines from the input text
                var textHeader = exp.SerializeTextHeader(this);
                var newText = "";
                bool skipFirstLine = true;
                foreach(var line in lines)
                {
                    if (line == textHeader || skipFirstLine)
                    {
                        skipFirstLine = false;
                        continue; // skip csv header
                    }
                    newText += line + Environment.NewLine;
                }
                exp.DeserializeText(newText, this);
            }
        }

        public void Serialize(BinaryWriter uexp, BinaryWriter uasset)
        {
            // Clearing Names would force all FNames to readd themselves, easy way to remove any unused names from the array
            // We don't add Names in the same order as UE itself yet tho, so this causes the whole names section to get shuffled around from the original
            // Maybe could be added as an optional parameter or something?
            // Names.Clear();

            // Write out export data first
            var uexpPosition = uexp.BaseStream.Position;
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

            // Update header
            Header.NameCount = Names.Count;
            Header.ImportCount = Imports.Count;
            Header.ExportCount = Exports.Count;
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

            byte[] unknownAfterExportBytes = { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            uasset.Write(unknownAfterExportBytes);

            Header.DependsOffset = (int)(uasset.BaseStream.Position - headerPosition);
            byte[] unknownDependsBytes = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            uasset.Write(unknownDependsBytes);

            Header.PreloadDependencyOffset = (int)(uasset.BaseStream.Position - headerPosition);
            foreach (var preloadDep in PreloadDependencies)
                uasset.Write(preloadDep);

            Header.TotalHeaderSize = (int)(uasset.BaseStream.Position - headerPosition);

            // Write updated section offsets/sizes to header:
            uasset.BaseStream.Position = headerPosition;
            Header.Serialize(uasset, this);
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

            // 8 unknown bytes after export: 02 00 00 00 00 00 00 00
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
                reader.BaseStream.Position = exp.SerialOffset + Header.TotalHeaderSize;
                var export = new AbstractExportObject();
                export.Deserialize(reader, this);
                ExportObjects.Add(export);
            }
        }
    }
}
