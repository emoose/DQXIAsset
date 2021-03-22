using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DQAsset
{
    public interface ISerializable
    {
        void Deserialize(BinaryReader reader, PackageFile package);

        void Serialize(BinaryWriter writer, PackageFile package);
    }

    public interface ISerializableText : ISerializable
    {
        void DeserializeText(string text, PackageFile package);
        string SerializeText(PackageFile package);
        string SerializeTextHeader(PackageFile package);
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Class)]
    public class SerializerAttribute : Attribute
    {
        // Struct size isn't contained in the uexp data, maybe there's a flag in uasset somewhere that defines this?
        public bool NoStructSize { get; set; }

        // Number of bytes/array elements
        public int Size { get; set; }

        // Won't be written into/read from CSV file, eg. for padding bytes, if used make sure to remove PropertiesData.Clear() line from Program.cs!
        public bool Hidden { get; set; }
    }
}
