using System.Xml.Linq;

namespace HKX2
{
    // hkpShapeModifier Signatire: 0xda8c7d7d size: 16 flags: FLAGS_NONE


    public partial class hkpShapeModifier : hkReferencedObject
    {


        public override uint Signature => 0xda8c7d7d;

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

