using System.Xml.Linq;

namespace HKX2
{
    // hkpKeyframedRigidMotion Signatire: 0xbafa2bb7 size: 320 flags: FLAGS_NONE


    public partial class hkpKeyframedRigidMotion : hkpMotion
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

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
        }
    }
}

