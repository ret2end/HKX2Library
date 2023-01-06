using System.Xml.Linq;

namespace HKX2
{
    // hkpNullCollisionFilter Signatire: 0xb120a34f size: 72 flags: FLAGS_NONE


    public partial class hkpNullCollisionFilter : hkpCollisionFilter
    {


        public override uint Signature => 0xb120a34f;

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

