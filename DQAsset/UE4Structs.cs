using System;
using System.Collections.Generic;

namespace DQAsset
{
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
}
