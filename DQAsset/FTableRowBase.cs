using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DQAsset
{
    public class FTableRowBase : ISerializableText
    {
        public string SerializeValueText(Type type, SerializerAttribute settings, PackageFile package, object value)
        {
            switch (type.Name)
            {
                case "String": // FString
                    var str = (string)value;
                    return str;
                    break;
                case "Byte[]":
                    var byt = ((byte[])value);
                    return BitConverter.ToString(byt);
                    break;
                case "Boolean":
                    return ((bool)value ? "1" : "0");
                case "Byte":
                    return ((byte)value).ToString();
                case "Int16":
                case "UInt16":
                    if (type.Name == "Int16")
                        return ((short)value).ToString();
                    else
                        return ((ushort)value).ToString();
                case "Int32":
                case "UInt32":
                    if (type.Name == "Int32")
                        return ((int)value).ToString();
                    else
                        return ((uint)value).ToString();
                case "Single":
                    return ((float)value).ToString();
                case "Double":
                    return ((double)value).ToString();
                case "Int64":
                case "UInt64":
                    if (type.Name == "Int64")
                        return ((long)value).ToString();
                    else
                        return ((ulong)value).ToString();
                    break;
                case "FName":
                    var name = (FName)value;
                    return name.Value;
                default:
                    if (type.IsEnum)
                    {
                        var enumType = Enum.GetUnderlyingType(type);
                        return Enum.GetName(type, value);
                    }
                    if (type.GetInterfaces().Contains(typeof(ISerializableText)))
                    {
                        var obj = value as ISerializableText;
                        return "\"" + obj.SerializeText(package) + "\"";
                    }
                    break;
            }

            return null;
        }

        public string SerializeText(PackageFile package)
        {
            var type = this.GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            string retVal = "";
            foreach (var field in fields)
            {
                var settings = field.GetCustomAttribute<SerializerAttribute>();
                if (settings != null && settings.Hidden)
                    continue;

                var fieldType = field.FieldType.Name;
                retVal += SerializeValueText(field.FieldType, settings, package, field.GetValue(this));
                retVal += ",";
            }
            // remove trailing comma
            if(retVal.Length > 0)
                retVal = retVal.Substring(0, retVal.Length - 1);
            return retVal;
        }

        public string SerializeTextHeader(PackageFile package)
        {
            var type = this.GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            string retVal = "";
            foreach (var field in fields)
            {
                var settings = field.GetCustomAttribute<SerializerAttribute>();
                if (settings != null && settings.Hidden)
                    continue;

                retVal += field.Name;
                retVal += ",";
            }
            // remove trailing comma
            if (retVal.Length > 0)
                retVal = retVal.Substring(0, retVal.Length - 1);
            return retVal;
        }

        public void DeserializeText(string text, PackageFile package)
        {

        }

        public void SerializeValue(Type type, SerializerAttribute settings, BinaryWriter writer, PackageFile package, object value)
        {
            switch(type.Name)
            {
                case "String": // FString
                    var str = (string)value;
                    writer.WriteFString(str);
                    break;
                case "Byte[]":
                    writer.Write((byte[])value);
                    break;
                case "Boolean":
                    var val = (bool)value;
                    writer.Write(val ? (byte)1 : (byte)0);
                    break;
                case "Byte":
                    writer.Write((byte)value);
                    break;
                case "Int16":
                case "UInt16":
                    if (type.Name == "Int16")
                        writer.Write((short)value);
                    else
                        writer.Write((ushort)value);
                    break;
                case "Int32":
                case "UInt32":
                    if (type.Name == "Int32")
                        writer.Write((int)value);
                    else
                        writer.Write((uint)value);
                    break;
                case "Single":
                    writer.Write((float)value);
                    break;
                case "Double":
                    writer.Write((double)value);
                    break;
                case "Int64":
                case "UInt64":
                    if (type.Name == "Int64")
                        writer.Write((long)value);
                    else
                        writer.Write((ulong)value);
                    break;
                case "FName":
                    var name = (FName)value;
                    name.Serialize(writer, package);
                    break;
                default:
                    if (type.IsEnum)
                    {
                        var enumType = Enum.GetUnderlyingType(type);
                        SerializeValue(enumType, settings, writer, package, value);
                    }
                    if (type.GetInterfaces().Contains(typeof(ISerializable)))
                    {
                        var obj = value as ISerializable;
                        obj.Serialize(writer, package);
                    }
                    break;
            }
        }

        public object DeserializeValue(Type type, SerializerAttribute settings, BinaryReader reader, PackageFile package)
        {
            switch (type.Name)
            {
                case "String": // FString
                    return reader.ReadFString();
                case "Byte[]":
                    int sz = settings?.Size ?? 0;
                    byte[] data = reader.ReadBytes(sz);
                    return data;
                case "Boolean":
                    return reader.ReadByte() != 0;
                case "Byte":
                    return reader.ReadByte();
                case "Int16":
                case "UInt16":
                    return type.Name == "Int16" ? (object)reader.ReadInt16() : (object)reader.ReadUInt16();
                case "Int32":
                case "UInt32":
                    return type.Name == "Int32" ? (object)reader.ReadInt32() : (object)reader.ReadUInt32();
                case "Single":
                    return reader.ReadSingle();
                case "Double":
                    return reader.ReadDouble();
                case "Int64":
                case "UInt64":
                    return type.Name == "Int64" ? (object)reader.ReadInt64() : (object)reader.ReadUInt64();
                case "FName":
                    var name = new FName();
                    name.Deserialize(reader, package);
                    return name;
                default:
                    if (type.IsEnum)
                    {
                        var enumType = Enum.GetUnderlyingType(type);
                        return DeserializeValue(enumType, settings, reader, package);
                    }
                    if (type.GetInterfaces().Contains(typeof(ISerializable)))
                    {
                        var obj = Activator.CreateInstance(type) as ISerializable;
                        obj.Deserialize(reader, package);
                        return obj;
                    }
                    break;
            }

            return null;
        }
        public void Deserialize(BinaryReader reader, PackageFile package)
        {
            var type = this.GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                var settings = field.GetCustomAttribute<SerializerAttribute>();
                var fieldType = field.FieldType.Name;
                object value = DeserializeValue(field.FieldType, settings, reader, package);
                field.SetValue(this, value);
            }
        }

        public void Serialize(BinaryWriter writer, PackageFile package)
        {
            var type = this.GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                var settings = field.GetCustomAttribute<SerializerAttribute>();
                var fieldType = field.FieldType.Name;
                SerializeValue(field.FieldType, settings, writer, package, field.GetValue(this));
            }
        }
    }
}
