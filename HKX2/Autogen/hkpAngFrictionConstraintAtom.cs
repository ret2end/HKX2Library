using System.Xml.Linq;

namespace HKX2
{
    // hkpAngFrictionConstraintAtom Signatire: 0xf313aa80 size: 12 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_firstFrictionAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags: FLAGS_NONE enum: 
    // m_numFrictionAxes m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_maxFrictionTorque m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpAngFrictionConstraintAtom : hkpConstraintAtom
    {
        public byte m_isEnabled;
        public byte m_firstFrictionAxis;
        public byte m_numFrictionAxes;
        public float m_maxFrictionTorque;

        public override uint Signature => 0xf313aa80;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_firstFrictionAxis = br.ReadByte();
            m_numFrictionAxes = br.ReadByte();
            br.Position += 3;
            m_maxFrictionTorque = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_firstFrictionAxis);
            bw.WriteByte(m_numFrictionAxes);
            bw.Position += 3;
            bw.WriteSingle(m_maxFrictionTorque);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_isEnabled = xd.ReadByte(xe, nameof(m_isEnabled));
            m_firstFrictionAxis = xd.ReadByte(xe, nameof(m_firstFrictionAxis));
            m_numFrictionAxes = xd.ReadByte(xe, nameof(m_numFrictionAxes));
            m_maxFrictionTorque = xd.ReadSingle(xe, nameof(m_maxFrictionTorque));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_isEnabled), m_isEnabled);
            xs.WriteNumber(xe, nameof(m_firstFrictionAxis), m_firstFrictionAxis);
            xs.WriteNumber(xe, nameof(m_numFrictionAxes), m_numFrictionAxes);
            xs.WriteFloat(xe, nameof(m_maxFrictionTorque), m_maxFrictionTorque);
        }
    }
}

