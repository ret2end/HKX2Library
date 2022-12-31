using System.Xml.Linq;

namespace HKX2
{
    // hkbPoweredRagdollControlData Signatire: 0xf5ba21b size: 32 flags: FLAGS_NONE

    // m_maxForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_proportionalRecoveryVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_constantRecoveryVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbPoweredRagdollControlData : IHavokObject
    {
        public float m_maxForce;
        public float m_tau;
        public float m_damping;
        public float m_proportionalRecoveryVelocity;
        public float m_constantRecoveryVelocity;

        public virtual uint Signature => 0xf5ba21b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_maxForce = br.ReadSingle();
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_proportionalRecoveryVelocity = br.ReadSingle();
            m_constantRecoveryVelocity = br.ReadSingle();
            br.Position += 12;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_maxForce);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_proportionalRecoveryVelocity);
            bw.WriteSingle(m_constantRecoveryVelocity);
            bw.Position += 12;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_maxForce), m_maxForce);
            xs.WriteFloat(xe, nameof(m_tau), m_tau);
            xs.WriteFloat(xe, nameof(m_damping), m_damping);
            xs.WriteFloat(xe, nameof(m_proportionalRecoveryVelocity), m_proportionalRecoveryVelocity);
            xs.WriteFloat(xe, nameof(m_constantRecoveryVelocity), m_constantRecoveryVelocity);
        }
    }
}

