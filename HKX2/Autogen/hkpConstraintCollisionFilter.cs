using System.Xml.Linq;

namespace HKX2
{
    // hkpConstraintCollisionFilter Signatire: 0xc3b577b1 size: 104 flags: FLAGS_NONE


    public partial class hkpConstraintCollisionFilter : hkpPairCollisionFilter
    {


        public override uint Signature => 0xc3b577b1;

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

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
        }
    }
}

