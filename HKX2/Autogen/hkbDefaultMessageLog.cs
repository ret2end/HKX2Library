using System.Xml.Linq;

namespace HKX2
{
    // hkbDefaultMessageLog Signatire: 0x7bd5c66f size: 1 flags: FLAGS_NONE


    public partial class hkbDefaultMessageLog : IHavokObject
    {
        public byte[] unk0;

        public virtual uint Signature => 0x7bd5c66f;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            unk0 = br.ReadBytes(1);
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

