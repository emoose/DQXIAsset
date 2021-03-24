using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace DQAsset
{
    public class FTableRowBase : ISerializableText
    {
        public object DeserializeValueText(Type type, SerializerAttribute settings, PackageFile package, string value)
        {
            // strip quotes from around value
            // if (value.StartsWith("\"\"") && value.EndsWith("\"\""))
            //     value = value.Substring(2, value.Length - 4);
            value = value.Replace("\"\"", "\"");
            if (value.StartsWith('"') && value.EndsWith('"'))
                value = value.Substring(1, value.Length - 2);

            switch (type.Name)
            {
                case "String":
                    return value;
                case "Byte[]":
                    return Shared.StringToByteArray(value);
                case "Boolean":
                    return value == "1" || value == "true" || value == "yes";
                case "Byte":
                    return byte.Parse(value);
                case "Int16":
                    return short.Parse(value);
                case "UInt16":
                    return ushort.Parse(value);
                case "Int32":
                    return int.Parse(value);
                case "UInt32":
                    return uint.Parse(value);
                case "Single":
                    return float.Parse(value);
                case "Double":
                    return double.Parse(value);
                case "Int64":
                    return long.Parse(value);
                case "UInt64":
                    return ulong.Parse(value);
                case "List`1":
                    // TArray
                    var elementType = type.GetGenericArguments()[0];
                    var listType = typeof(List<>).MakeGenericType(elementType);
                    var list = Activator.CreateInstance(listType) as IList;

                    if (value != "{}") // not empty:
                    {
                        if (value.StartsWith('{') && value.EndsWith('}'))
                            value = value.Substring(1, value.Length - 2);

                        var values = Shared.ProcessCsvRow(value).ToList();

                        foreach (var val in values)
                            list.Add(DeserializeValueText(elementType, settings, package, val));
                    }
                    
                    return list;
                case "FName":
                    return new FName(value);
                default:
                    if (type.IsEnum)
                    {
                        object enumResult;
                        if (Enum.TryParse(type, value, out enumResult))
                            return enumResult;
                        // if Enum.TryParse failed then the value isn't part of enum (and object struct is likely incorrect)
                        // Fallback to the enums underlying type
                        var enumType = Enum.GetUnderlyingType(type);
                        return DeserializeValueText(enumType, settings, package, value);
                    }
                    if (type.GetInterfaces().Contains(typeof(ISerializableText)))
                    {
                        var obj = Activator.CreateInstance(type) as ISerializableText;
                        obj.DeserializeText(value, package);
                        return obj;
                    }
                    break;
            }
            return null;
        }

        public string SerializeValueText(Type type, SerializerAttribute settings, PackageFile package, object value)
        {
            switch (type.Name)
            {
                case "String": // FString
                    var str = (string)value;
                    return str;
                    break;
                case "Byte[]":
                    var byt = (byte[])value;
                    return byt.ToHexString();
                    break;
                case "Boolean":
                    return (bool)value ? "true" : "false";
                case "Byte":
                    return ((byte)value).ToString();
                case "Int16":
                    return ((short)value).ToString();
                case "UInt16":
                    return ((ushort)value).ToString();
                case "Int32":
                    return ((int)value).ToString();
                case "UInt32":
                    return ((uint)value).ToString();
                case "Single":
                    return ((float)value).ToString();
                case "Double":
                    return ((double)value).ToString();
                case "Int64":
                    return ((long)value).ToString();
                case "UInt64":
                    return ((ulong)value).ToString();
                case "List`1":
                    var elementType = type.GetGenericArguments()[0];
                    var list = value as IList;

                    var result = "";
                    for (int i = 0; i < list.Count; i++)
                    {
                        result += SerializeValueText(elementType, settings, package, list[i]).Replace("\"", "\"\"");
                        if (i + 1 < list.Count)
                            result += ",";
                    }
                    result = "\"{" + result + "}\"";
                    return result;
                case "FName":
                    var name = (FName)value;
                    return name.ToString();
                default:
                    if (type.IsEnum)
                    {
                        var enumStr = Enum.GetName(type, value);
                        if (!string.IsNullOrEmpty(enumStr))
                            return enumStr;

                        // If Enum.GetName returned empty then the value isn't part of enum (and object struct is likely incorrect)
                        // Fallback to the enums underlying type
                        var enumType = Enum.GetUnderlyingType(type);
                        return SerializeValueText(enumType, settings, package, value);
                    }
                    if (type.GetInterfaces().Contains(typeof(ISerializableText)))
                    {
                        var obj = value as ISerializableText;
                        if (obj == null)
                            return "\"\"";
                        return "\"" + obj.SerializeText(package, false).Replace("\"", "\"\"") + "\"";
                    }
                    break;
            }

            return null;
        }

        public virtual string SerializeText(PackageFile package, bool isMainElement)
        {
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            string retVal = "";
            foreach (var field in fields)
            {
                var settings = field.GetCustomAttribute<SerializerAttribute>();
                if (settings != null && settings.Hidden)
                    continue;

                string valueText = "\"\"";
                if (FieldCanSerialize(field))
                {
                    valueText = SerializeValueText(field.FieldType, settings, package, field.GetValue(this));

                    // change outer escaped-quotes to regular quotes
                    if (isMainElement && valueText.StartsWith("\"\"") && valueText.EndsWith("\"\"") && valueText.Length > 4)
                        valueText = "\"" + valueText.Substring(2, valueText.Length - 4) + "\"";
                }

                // hack to escape anything that contains a comma, hope it doesn't break anything..
                if (valueText.Contains(",") && !valueText.Contains("\""))
                    valueText = "\"" + valueText + "\"";

                retVal += valueText;
                retVal += ",";
            }
            // remove trailing comma
            if(retVal.Length > 0)
                retVal = retVal.Substring(0, retVal.Length - 1);
            return retVal;
        }

        public virtual void DeserializeText(string text, PackageFile package)
        {
            var values = Shared.ProcessCsvRow(text).ToList();
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken).ToList(); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            int valueIdx = 0;
            for(int i = 0; i < fields.Count; i++)
            {
                var field = fields[i];

                // TODO: need to provide a default value for hidden fields, else they may be left as null (which our serialization code doesn't like!)
                var settings = field.GetCustomAttribute<SerializerAttribute>();
                if (settings != null && settings.Hidden) 
                    continue;

                if (FieldCanSerialize(field))
                {
                    object value = DeserializeValueText(field.FieldType, settings, package, values[valueIdx]);
                    field.SetValue(this, value);
                }

                valueIdx++;
            }
        }

        public string SerializeTextHeader(PackageFile package)
        {
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
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

        void SerializeBool(SerializerAttribute settings, BinaryWriter writer, PackageFile package, object value, bool isListElement)
        {
            var val = (bool)value;
            if (isListElement)
            {
                writer.Write(val ? (byte)1 : (byte)0);
                return;
            }
            else
            {
                if (settings != null)
                {
                    if (settings.Size == 1)
                    {
                        writer.Write(val ? (byte)1 : (byte)0);
                        return;
                    }
                    if (settings.Size == 2)
                    {
                        writer.Write(val ? (ushort)1 : (ushort)0);
                        return;
                    }
                    if (settings.Size == 4)
                    {
                        writer.Write(val ? (uint)1 : (uint)0);
                        return;
                    }
                    if (settings.Size == 8)
                    {
                        writer.Write(val ? (ulong)1 : (ulong)0);
                        return;
                    }
                }
            }
            writer.Write(val ? (int)1 : (int)0);
        }

        public void SerializeValue(Type type, SerializerAttribute settings, BinaryWriter writer, PackageFile package, object value, bool isListElement = false)
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
                    SerializeBool(settings, writer, package, value, isListElement);
                    break;
                case "Byte":
                    writer.Write((byte)value);
                    break;
                case "Int16":
                    writer.Write((short)value);
                    break;
                case "UInt16":
                    writer.Write((ushort)value);
                    break;
                case "Int32":
                    writer.Write((int)value);
                    break;
                case "UInt32":
                    writer.Write((uint)value);
                    break;
                case "Single":
                    writer.Write((float)value);
                    break;
                case "Double":
                    writer.Write((double)value);
                    break;
                case "Int64":
                    writer.Write((long)value);
                    break;
                case "UInt64":
                    writer.Write((ulong)value);
                    break;
                case "List`1":
                    var elementType = type.GetGenericArguments()[0];
                    var list = value as IList;
                    writer.Write(list.Count);
                    for(int i = 0; i < list.Count; i++)
                        SerializeValue(elementType, settings, writer, package, list[i], true);

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

        object DeserializeBool(SerializerAttribute settings, BinaryReader reader, PackageFile package, bool isListElement)
        {
            if (isListElement)
                return reader.ReadByte() != 0;
            if (settings != null)
            {
                if(settings.Size == 1)
                    return reader.ReadByte() != 0;
                if (settings.Size == 2)
                    return reader.ReadUInt16() != 0;
                if (settings.Size == 4)
                    return reader.ReadUInt32() != 0;
                if (settings.Size == 8)
                    return reader.ReadUInt64() != 0;
            }
            return reader.ReadUInt32() != 0;
        }

        public object DeserializeValue(Type type, SerializerAttribute settings, BinaryReader reader, PackageFile package, bool isListElement = false)
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
                    return DeserializeBool(settings, reader, package, isListElement);
                case "Byte":
                    return reader.ReadByte();
                case "Int16":
                    return reader.ReadInt16();
                case "UInt16":
                    return reader.ReadUInt16();
                case "Int32":
                    return reader.ReadInt32();
                case "UInt32":
                    return reader.ReadUInt32();
                case "Single":
                    return reader.ReadSingle();
                case "Double":
                    return reader.ReadDouble();
                case "Int64":
                    return reader.ReadInt64();
                case "UInt64":
                    return reader.ReadUInt64();
                case "List`1":
                    // TArray
                    var elementType = type.GetGenericArguments()[0];
                    var listType = typeof(List<>).MakeGenericType(elementType);
                    var list = Activator.CreateInstance(listType) as IList;

                    int count = reader.ReadInt32();
                    for(int i = 0; i < count; i++)
                        list.Add(DeserializeValue(elementType, settings, reader, package, true));

                    return list;
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

        bool CheckIsSet(string fieldName)
        {
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                if(field.Name == fieldName)
                {
                    if(field.FieldType == typeof(FName))
                    {
                        var name = field.GetValue(this) as FName;
                        return name.Value != "None";
                    }
                    if (field.FieldType == typeof(byte))
                        return (byte)field.GetValue(this) == 1;
                    if (field.FieldType == typeof(short))
                        return (short)field.GetValue(this) == 1;
                    if (field.FieldType == typeof(int))
                        return (int)field.GetValue(this) == 1;
                    if (field.FieldType == typeof(long))
                        return (long)field.GetValue(this) == 1;
                    if (field.FieldType == typeof(ushort))
                        return (ushort)field.GetValue(this) == 1;
                    if (field.FieldType == typeof(uint))
                        return (uint)field.GetValue(this) == 1;
                    if (field.FieldType == typeof(ulong))
                        return (ulong)field.GetValue(this) == 1;

                    return (bool)field.GetValue(this);
                }
            }
            return false;
        }

        bool FieldCanSerialize(FieldInfo field)
        {
            var settings = field.GetCustomAttribute<SerializerAttribute>();

            if (settings == null)
                return true;

            if (!string.IsNullOrEmpty(settings.OnlyIfSet))
                if (!CheckIsSet(settings.OnlyIfSet))
                    return false;

            if (!string.IsNullOrEmpty(settings.OnlyIfNotSet))
                if (CheckIsSet(settings.OnlyIfNotSet))
                    return false;

            if(settings.OnlyIfAllSet != null && settings.OnlyIfAllSet.Length > 0)
                foreach (var field2 in settings.OnlyIfAllSet)
                    if (!CheckIsSet(field2))
                        return false;

            if (settings.OnlyIfAllNotSet != null && settings.OnlyIfAllNotSet.Length > 0)
                foreach (var field2 in settings.OnlyIfAllNotSet)
                    if (CheckIsSet(field2))
                        return false;

            return true;
        }

        public virtual void Deserialize(BinaryReader reader, PackageFile package)
        {
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                if (!FieldCanSerialize(field))
                    continue;

                var settings = field.GetCustomAttribute<SerializerAttribute>();

                var fieldType = field.FieldType.Name;
                object value = DeserializeValue(field.FieldType, settings, reader, package);
                field.SetValue(this, value);
            }
        }

        public virtual void Serialize(BinaryWriter writer, PackageFile package)
        {
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                if (!FieldCanSerialize(field))
                    continue;

                var settings = field.GetCustomAttribute<SerializerAttribute>();

                var fieldType = field.FieldType.Name;
                SerializeValue(field.FieldType, settings, writer, package, field.GetValue(this));
            }
        }
    }
}
