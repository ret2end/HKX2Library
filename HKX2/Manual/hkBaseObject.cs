using System.Xml.Linq;

namespace HKX2
{
    // hkBaseObject Signatire: 0xe0708a00 size: 8 flags: FLAGS_NONE



    public partial class hkBaseObject : IHavokObject
    {
        public virtual uint Signature => 0xe0708a00;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUSize();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUSize(0);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {

        }
    }
}

