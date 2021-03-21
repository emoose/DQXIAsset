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
        public int Size { get; set; }
        public bool Hidden { get; set; }
    }
}
