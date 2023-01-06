using System.Xml.Linq;

namespace HKX2
{
    // hkpCogWheelConstraintAtom Signatire: 0xf2b1f399 size: 16 flags: FLAGS_NONE

    // m_cogWheelRadiusA m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_cogWheelRadiusB m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_isScrew m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_memOffsetToInitialAngleOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 13 flags: FLAGS_NONE enum: 
    // m_memOffsetToPrevAngle m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 14 flags: FLAGS_NONE enum: 
    // m_memOffsetToRevolutionCounter m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 15 flags: FLAGS_NONE enum: 
    public partial class hkpCogWheelConstraintAtom : hkpConstraintAtom
    {
        public float m_cogWheelRadiusA;
        public float m_cogWheelRadiusB;
        public bool m_isScrew;
        public sbyte m_memOffsetToInitialAngleOffset;
        public sbyte m_memOffsetToPrevAngle;
        public sbyte m_memOffsetToRevolutionCounter;

        public override uint Signature => 0xf2b1f399;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 2;
            m_cogWheelRadiusA = br.ReadSingle();
            m_cogWheelRadiusB = br.ReadSingle();
            m_isScrew = br.ReadBoolean();
            m_memOffsetToInitialAngleOffset = br.ReadSByte();
            m_memOffsetToPrevAngle = br.ReadSByte();
            m_memOffsetToRevolutionCounter = br.ReadSByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 2;
            bw.WriteSingle(m_cogWheelRadiusA);
            bw.WriteSingle(m_cogWheelRadiusB);
            bw.WriteBoolean(m_isScrew);
            bw.WriteSByte(m_memOffsetToInitialAngleOffset);
            bw.WriteSByte(m_memOffsetToPrevAngle);
            bw.WriteSByte(m_memOffsetToRevolutionCounter);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_cogWheelRadiusA = xd.ReadSingle(xe, nameof(m_cogWheelRadiusA));
            m_cogWheelRadiusB = xd.ReadSingle(xe, nameof(m_cogWheelRadiusB));
            m_isScrew = xd.ReadBoolean(xe, nameof(m_isScrew));
            m_memOffsetToInitialAngleOffset = xd.ReadSByte(xe, nameof(m_memOffsetToInitialAngleOffset));
            m_memOffsetToPrevAngle = xd.ReadSByte(xe, nameof(m_memOffsetToPrevAngle));
            m_memOffsetToRevolutionCounter = xd.ReadSByte(xe, nameof(m_memOffsetToRevolutionCounter));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_cogWheelRadiusA), m_cogWheelRadiusA);
            xs.WriteFloat(xe, nameof(m_cogWheelRadiusB), m_cogWheelRadiusB);
            xs.WriteBoolean(xe, nameof(m_isScrew), m_isScrew);
            xs.WriteNumber(xe, nameof(m_memOffsetToInitialAngleOffset), m_memOffsetToInitialAngleOffset);
            xs.WriteNumber(xe, nameof(m_memOffsetToPrevAngle), m_memOffsetToPrevAngle);
            xs.WriteNumber(xe, nameof(m_memOffsetToRevolutionCounter), m_memOffsetToRevolutionCounter);
        }
    }
}

