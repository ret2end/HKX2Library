using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace HKX2
{
    public static class Util
    {
        public static IHavokObject ReadHKX(Stream stream)
        {
            var des = new PackFileDeserializer();
            var br = new BinaryReaderEx(stream);

            return des.Deserialize(br);
        }

        public static IHavokObject ReadHKX(string filePath)
        {
            using FileStream stream = File.OpenRead(filePath);
            return ReadHKX(stream);
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

        public static void WriteHKX(IHavokObject root, HKXHeader header, string filePath)
        {
            using FileStream stream = File.OpenRead(filePath);
            WriteHKX(root, header, stream);
        }

        public static byte[] WriteHKX(IHavokObject root, HKXHeader header)
        {
            var ms = new MemoryStream();
            WriteHKX(root, header, ms);
            return ms.ToArray();
        }

        public static IHavokObject ReadXml(Stream stream, HKXHeader header)
        {
            var xd = new XmlDeserializer();
            return xd.Deserialize(stream, header);
        }

        public static IHavokObject ReadXml(string filePath, HKXHeader header)
        {
            using FileStream stream = File.OpenRead(filePath);
            return ReadXml(stream, header);
        }

        public static void WriteXml(IHavokObject root, HKXHeader header, Stream stream)
        {
            var s = new XmlSerializer();
            s.Serialize(root, header, stream);
        }

        public static void WriteXml(IHavokObject root, HKXHeader header, string filePath)
        {
            using FileStream stream = File.OpenRead(filePath);
            WriteXml(root, header, stream);
        }
    }
}
