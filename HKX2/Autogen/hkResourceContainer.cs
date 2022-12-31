using System.Xml.Linq;

namespace HKX2
{
    // hkResourceContainer Signatire: 0x4e94146 size: 16 flags: FLAGS_NONE


    public partial class hkResourceContainer : hkResourceBase
    {


        public override uint Signature => 0x4e94146;

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

