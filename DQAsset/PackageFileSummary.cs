using System.Collections.Generic;
using System.IO;

namespace DQAsset
{
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
        public int GatherableTextDataCount;
        public int GatherableTextDataOffset;
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

        public FEngineVersion SavedByEngineVersion;
        public FEngineVersion CompatibleWithEngineVersion;

        // TODO: why was this missing before?
        public uint CompressionFlags;

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

        public bool IsVersionOrGreater(UE4Versions Version)
        {
            int FileVer = FileVersionUE4;
            if (FileVer == 0)
                FileVer = 514; // workaround for unversioned DQXIS files, 514 is latest ver in 4.18.3

            return FileVer >= (int)Version;
        }

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

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID))
                writer.WriteFString(LocalizationId);

            if (IsVersionOrGreater(UE4Versions.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES))
            {
                writer.Write(GatherableTextDataCount);
                writer.Write(GatherableTextDataOffset);
            }

            writer.Write(ExportCount);
            writer.Write(ExportOffset);
            writer.Write(ImportCount);
            writer.Write(ImportOffset);
            writer.Write(DependsOffset);

            if (!IsVersionOrGreater(UE4Versions.VER_UE4_OLDEST_LOADABLE_PACKAGE))
                return;

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP))
            {
                writer.Write(SoftPackageReferencesCount);
                writer.Write(SoftPackageReferencesOffset);
            }

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_SEARCHABLE_NAMES))
                writer.Write(SearchableNamesOffset);

            writer.Write(ThumbnailTableOffset);

            writer.Write(Guid);

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_PACKAGE_OWNER))
            {
                writer.Write(PersistentGuid);
                writer.Write(OwnerPersistentGuid);
            }

            GenerationCount = Generations.Count;
            writer.Write(GenerationCount);
            foreach (var gen in Generations)
                writer.WriteStruct(gen);

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ENGINE_VERSION_OBJECT))
                SavedByEngineVersion.Serialize(writer, package);
            else
                writer.Write(SavedByEngineVersion.Changelist);

            if (IsVersionOrGreater(UE4Versions.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION))
                CompatibleWithEngineVersion.Serialize(writer, package);

            writer.Write(CompressionFlags);

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

            if (IsVersionOrGreater(UE4Versions.VER_UE4_WORLD_LEVEL_INFO))
                writer.Write(WorldTileInfoDataOffset);

            ChunkIdCount = 0;
            if (ChunkIds != null)
                ChunkIdCount = ChunkIds.Count;

            if (IsVersionOrGreater(UE4Versions.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS))
            {
                writer.Write(ChunkIdCount);
                foreach (var chunk in ChunkIds)
                    writer.Write(chunk);
            }
            else if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_CHUNKID_TO_ASSETDATA_AND_UPACKAGE))
                writer.Write(ChunkIdCount > 0 ? ChunkIds[0] : 0);

            if (IsVersionOrGreater(UE4Versions.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                writer.Write(PreloadDependencyCount);
                writer.Write(PreloadDependencyOffset);
            }
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

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID))
                LocalizationId = reader.ReadFString();

            if (IsVersionOrGreater(UE4Versions.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES))
            {
                GatherableTextDataCount = reader.ReadInt32();
                GatherableTextDataOffset = reader.ReadInt32();
            }

            ExportCount = reader.ReadInt32();
            ExportOffset = reader.ReadInt32();
            ImportCount = reader.ReadInt32();
            ImportOffset = reader.ReadInt32();
            DependsOffset = reader.ReadInt32();

            if (!IsVersionOrGreater(UE4Versions.VER_UE4_OLDEST_LOADABLE_PACKAGE))
                return;

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP))
            {
                SoftPackageReferencesCount = reader.ReadInt32();
                SoftPackageReferencesOffset = reader.ReadInt32();
            }

            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_SEARCHABLE_NAMES))
                SearchableNamesOffset = reader.ReadInt32();

            ThumbnailTableOffset = reader.ReadInt32();
            Guid = reader.ReadBytes(0x10);
            if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_PACKAGE_OWNER))
            {
                PersistentGuid = reader.ReadBytes(0x10);
                OwnerPersistentGuid = reader.ReadBytes(0x10);
            }

            GenerationCount = reader.ReadInt32();
            Generations = new List<GenerationInfo>();
            for (int i = 0; i < GenerationCount; i++)
                Generations.Add(reader.ReadStruct<GenerationInfo>());

            SavedByEngineVersion = new FEngineVersion();
            if (IsVersionOrGreater(UE4Versions.VER_UE4_ENGINE_VERSION_OBJECT))
                SavedByEngineVersion.Deserialize(reader, package);
            else
                SavedByEngineVersion.Changelist = reader.ReadUInt32();

            if (IsVersionOrGreater(UE4Versions.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION))
            {
                CompatibleWithEngineVersion = new FEngineVersion();
                CompatibleWithEngineVersion.Deserialize(reader, package);
            }

            CompressionFlags = reader.ReadUInt32();

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

            if (IsVersionOrGreater(UE4Versions.VER_UE4_WORLD_LEVEL_INFO))
                WorldTileInfoDataOffset = reader.ReadInt32();

            if (IsVersionOrGreater(UE4Versions.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS))
            {
                ChunkIdCount = reader.ReadInt32();
                ChunkIds = new List<int>();
                for (int i = 0; i < ChunkIdCount; i++)
                    ChunkIds.Add(reader.ReadInt32());
            }
            else if (IsVersionOrGreater(UE4Versions.VER_UE4_ADDED_CHUNKID_TO_ASSETDATA_AND_UPACKAGE))
            {
                ChunkIdCount = 1;
                ChunkIds = new List<int>();
                ChunkIds.Add(reader.ReadInt32());
            }

            if (IsVersionOrGreater(UE4Versions.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                PreloadDependencyCount = reader.ReadInt32();
                PreloadDependencyOffset = reader.ReadInt32();
            }
        }
    }
}
