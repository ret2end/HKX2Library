using System.Xml.Linq;

namespace HKX2
{
    // hkpViscousSurfaceModifierConstraintAtom Signatire: 0x5c6aa14d size: 48 flags: FLAGS_NONE


    public partial class hkpViscousSurfaceModifierConstraintAtom : hkpModifierConstraintAtom
    {


        public override uint Signature => 0x5c6aa14d;

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

