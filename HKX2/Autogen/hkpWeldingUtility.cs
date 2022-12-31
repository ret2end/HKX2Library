using System.Xml.Linq;

namespace HKX2
{
    // hkpWeldingUtility Signatire: 0xb2b41feb size: 1 flags: FLAGS_NONE


    public partial class hkpWeldingUtility : IHavokObject
    {
        public byte[] unk0;

        public virtual uint Signature => 0xb2b41feb;

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

