using System.Xml.Linq;

namespace HKX2
{
    // hkpConeLimitConstraintAtom Signatire: 0xf19443c8 size: 20 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_twistAxisInA m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags: FLAGS_NONE enum: 
    // m_refAxisInB m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_angleMeasurementMode m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 5 flags: FLAGS_NONE enum: MeasurementMode
    // m_memOffsetToAngleOffset m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 6 flags: FLAGS_NONE enum: 
    // m_minAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_maxAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_angularLimitsTauFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkpConeLimitConstraintAtom : hkpConstraintAtom
    {
        public byte m_isEnabled;
        public byte m_twistAxisInA;
        public byte m_refAxisInB;
        public byte m_angleMeasurementMode;
        public byte m_memOffsetToAngleOffset;
        public float m_minAngle;
        public float m_maxAngle;
        public float m_angularLimitsTauFactor;

        public override uint Signature => 0xf19443c8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_twistAxisInA = br.ReadByte();
            m_refAxisInB = br.ReadByte();
            m_angleMeasurementMode = br.ReadByte();
            m_memOffsetToAngleOffset = br.ReadByte();
            br.Position += 1;
            m_minAngle = br.ReadSingle();
            m_maxAngle = br.ReadSingle();
            m_angularLimitsTauFactor = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_twistAxisInA);
            bw.WriteByte(m_refAxisInB);
            s.WriteByte(bw, m_angleMeasurementMode);
            bw.WriteByte(m_memOffsetToAngleOffset);
            bw.Position += 1;
            bw.WriteSingle(m_minAngle);
            bw.WriteSingle(m_maxAngle);
            bw.WriteSingle(m_angularLimitsTauFactor);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_isEnabled = xd.ReadByte(xe, nameof(m_isEnabled));
            m_twistAxisInA = xd.ReadByte(xe, nameof(m_twistAxisInA));
            m_refAxisInB = xd.ReadByte(xe, nameof(m_refAxisInB));
            m_angleMeasurementMode = xd.ReadFlag<MeasurementMode, byte>(xe, nameof(m_angleMeasurementMode));
            m_memOffsetToAngleOffset = xd.ReadByte(xe, nameof(m_memOffsetToAngleOffset));
            m_minAngle = xd.ReadSingle(xe, nameof(m_minAngle));
            m_maxAngle = xd.ReadSingle(xe, nameof(m_maxAngle));
            m_angularLimitsTauFactor = xd.ReadSingle(xe, nameof(m_angularLimitsTauFactor));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_isEnabled), m_isEnabled);
            xs.WriteNumber(xe, nameof(m_twistAxisInA), m_twistAxisInA);
            xs.WriteNumber(xe, nameof(m_refAxisInB), m_refAxisInB);
            xs.WriteEnum<MeasurementMode, byte>(xe, nameof(m_angleMeasurementMode), m_angleMeasurementMode);
            xs.WriteNumber(xe, nameof(m_memOffsetToAngleOffset), m_memOffsetToAngleOffset);
            xs.WriteFloat(xe, nameof(m_minAngle), m_minAngle);
            xs.WriteFloat(xe, nameof(m_maxAngle), m_maxAngle);
            xs.WriteFloat(xe, nameof(m_angularLimitsTauFactor), m_angularLimitsTauFactor);
        }
    }
}

