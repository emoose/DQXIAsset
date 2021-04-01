using System;
using System.Collections.Generic;

namespace DQAsset
{
    public struct GenerationInfo
    {
        public int ExportCount;
        public int NameCount;
    }

    public struct CompressedChunk
    {
        public int UncompressedOffset;
        public int UncompressedSize;
        public int CompressedOffset;
        public int CompressedSize;
    }

    public class FVector2D : FTableRowBase
    {
        public float X;
        public float Y;
    }

    public class FVector : FTableRowBase
    {
        public float X;
        public float Y;
        public float Z;
    }

    public class FRotator : FTableRowBase
    {
        public float Pitch;
        public float Yaw;
        public float Roll;
    }

    public class FLinearColor : FTableRowBase
    {
        public float R;
        public float G;
        public float B;
        public float A;
    }

    // ScriptStruct CoreUObject.Quat
    // 0x0010
    public class FQuat : FTableRowBase
    {
        public float X;                                                        // 0x0000(0x0004) (Edit, BlueprintVisi, ZeroConstructor, SaveGame, IsPlainOldData)
        public float Y;                                                        // 0x0004(0x0004) (Edit, BlueprintVisi, ZeroConstructor, SaveGame, IsPlainOldData)
        public float Z;                                                        // 0x0008(0x0004) (Edit, BlueprintVisi, ZeroConstructor, SaveGame, IsPlainOldData)
        public float W;                                                        // 0x000C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, SaveGame, IsPlainOldData)
    }

    // ScriptStruct CoreUObject.Transform
    // 0x0030
    public class FTransform : FTableRowBase
    {
        public FQuat Rotation;                                                 // 0x0000(0x0010) (Edit, BlueprintVisi, SaveGame, IsPlainOldData)
        public FVector Translation;                                              // 0x0010(0x000C) (Edit, BlueprintVisi, SaveGame, IsPlainOldData)
        public FVector Scale3D;                                                  // 0x0020(0x000C) (Edit, BlueprintVisi, SaveGame, IsPlainOldData)
    }

    public class UObject : FTableRowBase
    {
        public FName Unknown0x0;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Unknown0x8;
        public FName Unknown0x10;
        public byte Unknown0x18;
        public int ClassIndex;
        public FName Unknown0x1D;
    }
}
