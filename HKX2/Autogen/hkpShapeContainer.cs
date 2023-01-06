using System.Xml.Linq;

namespace HKX2
{
    // hkpShapeContainer Signatire: 0xe0708a00 size: 8 flags: FLAGS_NONE


    public partial class hkpShapeContainer : IHavokObject
    {
        public byte[] unk0 = new byte[8];

        public virtual uint Signature => 0xe0708a00;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            unk0 = br.ReadBytes(8);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBytes(unk0);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {

        }
    }
}

