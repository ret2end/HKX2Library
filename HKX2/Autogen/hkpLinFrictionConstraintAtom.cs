using System.Xml.Linq;

namespace HKX2
{
    // hkpLinFrictionConstraintAtom Signatire: 0x3e94ef7c size: 8 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_frictionAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags: FLAGS_NONE enum: 
    // m_maxFrictionForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkpLinFrictionConstraintAtom : hkpConstraintAtom
    {
        public byte m_isEnabled;
        public byte m_frictionAxis;
        public float m_maxFrictionForce;

        public override uint Signature => 0x3e94ef7c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_frictionAxis = br.ReadByte();
            m_maxFrictionForce = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_frictionAxis);
            bw.WriteSingle(m_maxFrictionForce);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_isEnabled), m_isEnabled);
            xs.WriteNumber(xe, nameof(m_frictionAxis), m_frictionAxis);
            xs.WriteFloat(xe, nameof(m_maxFrictionForce), m_maxFrictionForce);
        }
    }
}

