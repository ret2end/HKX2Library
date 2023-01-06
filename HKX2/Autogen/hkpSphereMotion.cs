using System.Xml.Linq;

namespace HKX2
{
    // hkpSphereMotion Signatire: 0xbafa2bb7 size: 320 flags: FLAGS_NONE


    public partial class hkpSphereMotion : hkpMotion
    {


        public override uint Signature => 0xbafa2bb7;

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

