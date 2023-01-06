using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpAngularDashpotAction Signatire: 0x35f4c487 size: 96 flags: FLAGS_NONE

    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    public partial class hkpAngularDashpotAction : hkpBinaryAction
    {
        public Quaternion m_rotation;
        public float m_strength;
        public float m_damping;

        public override uint Signature => 0x35f4c487;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rotation = des.ReadQuaternion(br);
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotation);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_rotation = xd.ReadQuaternion(xe, nameof(m_rotation));
            m_strength = xd.ReadSingle(xe, nameof(m_strength));
            m_damping = xd.ReadSingle(xe, nameof(m_damping));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteQuaternion(xe, nameof(m_rotation), m_rotation);
            xs.WriteFloat(xe, nameof(m_strength), m_strength);
            xs.WriteFloat(xe, nameof(m_damping), m_damping);
        }
    }
}

