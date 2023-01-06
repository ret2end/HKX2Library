using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace HKX2
{
    public static class Util
    {
        private static readonly Dictionary<string, short> BotwSectionOffsetForExtension =
            new()
            {
                {".hkcl", 0},
                {".hkrg", 0},
                {".hkrb", 0},
                {".hktmrb", 16},
                {".hknm2", 16}
            };

        public static IHavokObject ReadHKX(Stream stream)
        {
            var des = new PackFileDeserializer();
            var br = new BinaryReaderEx(stream);

            return des.Deserialize(br);
        }

        public static IHavokObject ReadHKX(byte[] bytes)
        {
            return ReadHKX(new MemoryStream(bytes));
        }

        public static void WriteHKX(IHavokObject root, HKXHeader header, Stream stream)
        {
            var s = new PackFileSerializer();
            var bw = new BinaryWriterEx(stream);

            s.Serialize(root, bw, header);
        }

        public static byte[] WriteHKX(IHavokObject root, HKXHeader header)
        {
            var ms = new MemoryStream();
            WriteHKX(root, header, ms);
            return ms.ToArray();
        }

        public static T ToNumber<T, TEnum>(this TEnum enumType) where TEnum : Enum where T : IBinaryInteger<T>
        {
            return (T)(IConvertible)enumType;
        }
        public static V ToNumber<T, V>(this string value) where T : Enum where V : IBinaryInteger<V>
        {
            return (V)Enum.Parse(typeof(T), value);
        }

        public static T ToEnum<T, V>(this V value) where T : Enum where V : IBinaryInteger<V>
        {
            return (T)(IConvertible)value;
        }

        public static string ToSerlializedEnum<TEnum, V>(this V value) where TEnum : Enum where V : IBinaryInteger<V>
        {
            return Enum.GetName(typeof(TEnum), value);
        }

        public static string ToSerlializedFlag<TEnum, V>(this V value) where TEnum : Enum where V : IBinaryInteger<V>
        {
            var result = new List<string>();
            var enums = (TEnum[])Enum.GetValues(typeof(TEnum));
            for (int i = enums.Length - 1; i >= 0; i--)
            {
                if (enums[i].ToNumber<V, TEnum>() == V.Zero)
                {
                    break;
                }
                if ((enums[i].ToNumber<V, TEnum>() & value) == enums[i].ToNumber<V, TEnum>())
                {
                    result.Add(enums[i].ToString());
                    value &= ~enums[i].ToNumber<V, TEnum>();
                    if (value == V.Zero)
                    {
                        break;
                    }
                }
            }
            if (value > V.Zero)
            {
                result.Add(value.ToString());
                //throw new Exception("Invaild enum value.");
            }
            if (result.Count == 0)
            {
                result.Add(enums[0].ToString());
            }
            return string.Join("|", result);
        }

        public static V ToFlagValue<TEnum, V>(this string[] value) where TEnum : Enum where V : IBinaryInteger<V>
        {
            V result = V.Zero;
            foreach (var item in value)
            {
                result |= item.ToNumber<TEnum, V>();
            }
            return result;
        }
    }
}
