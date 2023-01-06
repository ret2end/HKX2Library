using System.Xml.Linq;

namespace HKX2
{
    // BSLimbIKModifier Signatire: 0x8ea971e5 size: 120 flags: FLAGS_NONE

    // m_limitAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_currentAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_startBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_endBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 90 flags: FLAGS_NONE enum: 
    // m_gain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_boneRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_castOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_pSkeletonMemory m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSLimbIKModifier : hkbModifier
    {
        public float m_limitAngleDegrees;
        public float m_currentAngle;
        public short m_startBoneIndex;
        public short m_endBoneIndex;
        public float m_gain;
        public float m_boneRadius;
        public float m_castOffset;
        public float m_timeStep;
        public dynamic m_pSkeletonMemory;

        public override uint Signature => 0x8ea971e5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_limitAngleDegrees = br.ReadSingle();
            m_currentAngle = br.ReadSingle();
            m_startBoneIndex = br.ReadInt16();
            m_endBoneIndex = br.ReadInt16();
            m_gain = br.ReadSingle();
            m_boneRadius = br.ReadSingle();
            m_castOffset = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_limitAngleDegrees);
            bw.WriteSingle(m_currentAngle);
            bw.WriteInt16(m_startBoneIndex);
            bw.WriteInt16(m_endBoneIndex);
            bw.WriteSingle(m_gain);
            bw.WriteSingle(m_boneRadius);
            bw.WriteSingle(m_castOffset);
            bw.WriteSingle(m_timeStep);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_limitAngleDegrees = xd.ReadSingle(xe, nameof(m_limitAngleDegrees));
            m_currentAngle = default;
            m_startBoneIndex = xd.ReadInt16(xe, nameof(m_startBoneIndex));
            m_endBoneIndex = xd.ReadInt16(xe, nameof(m_endBoneIndex));
            m_gain = xd.ReadSingle(xe, nameof(m_gain));
            m_boneRadius = xd.ReadSingle(xe, nameof(m_boneRadius));
            m_castOffset = xd.ReadSingle(xe, nameof(m_castOffset));
            m_timeStep = default;
            m_pSkeletonMemory = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_limitAngleDegrees), m_limitAngleDegrees);
            xs.WriteSerializeIgnored(xe, nameof(m_currentAngle));
            xs.WriteNumber(xe, nameof(m_startBoneIndex), m_startBoneIndex);
            xs.WriteNumber(xe, nameof(m_endBoneIndex), m_endBoneIndex);
            xs.WriteFloat(xe, nameof(m_gain), m_gain);
            xs.WriteFloat(xe, nameof(m_boneRadius), m_boneRadius);
            xs.WriteFloat(xe, nameof(m_castOffset), m_castOffset);
            xs.WriteSerializeIgnored(xe, nameof(m_timeStep));
            xs.WriteSerializeIgnored(xe, nameof(m_pSkeletonMemory));
        }
    }
}

