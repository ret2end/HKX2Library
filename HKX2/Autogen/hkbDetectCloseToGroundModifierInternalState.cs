using System.Xml.Linq;

namespace HKX2
{
    // hkbDetectCloseToGroundModifierInternalState Signatire: 0x7b32d942 size: 24 flags: FLAGS_NONE

    // m_isCloseToGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbDetectCloseToGroundModifierInternalState : hkReferencedObject
    {
        public bool m_isCloseToGround;

        public override uint Signature => 0x7b32d942;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isCloseToGround = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_isCloseToGround);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_isCloseToGround = xd.ReadBoolean(xe, nameof(m_isCloseToGround));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_isCloseToGround), m_isCloseToGround);
        }
    }
}

