using System.Xml.Linq;

namespace HKX2
{
    // hkpDefaultConvexListFilter Signatire: 0xb69c1c02 size: 16 flags: FLAGS_NONE


    public partial class hkpDefaultConvexListFilter : hkpConvexListFilter
    {


        public override uint Signature => 0xb69c1c02;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
        }
    }
}

