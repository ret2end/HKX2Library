using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbTwistModifier Signatire: 0xb6b76b32 size: 144 flags: FLAGS_NONE

    // m_axisOfRotation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_twistAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_startBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_endBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 102 flags: FLAGS_NONE enum: 
    // m_setAngleMethod m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 104 flags: FLAGS_NONE enum: SetAngleMethod
    // m_rotationAxisCoordinates m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 105 flags: FLAGS_NONE enum: RotationAxisCoordinates
    // m_isAdditive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 106 flags: FLAGS_NONE enum: 
    // m_boneChainIndices m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_parentBoneIndices m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 128 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbTwistModifier : hkbModifier
    {
        public Vector4 m_axisOfRotation;
        public float m_twistAngle;
        public short m_startBoneIndex;
        public short m_endBoneIndex;
        public sbyte m_setAngleMethod;
        public sbyte m_rotationAxisCoordinates;
        public bool m_isAdditive;
        public List<dynamic> m_boneChainIndices;
        public List<dynamic> m_parentBoneIndices;

        public override uint Signature => 0xb6b76b32;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_axisOfRotation = br.ReadVector4();
            m_twistAngle = br.ReadSingle();
            m_startBoneIndex = br.ReadInt16();
            m_endBoneIndex = br.ReadInt16();
            m_setAngleMethod = br.ReadSByte();
            m_rotationAxisCoordinates = br.ReadSByte();
            m_isAdditive = br.ReadBoolean();
            br.Position += 5;
            des.ReadEmptyArray(br);
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_axisOfRotation);
            bw.WriteSingle(m_twistAngle);
            bw.WriteInt16(m_startBoneIndex);
            bw.WriteInt16(m_endBoneIndex);
            s.WriteSByte(bw, m_setAngleMethod);
            s.WriteSByte(bw, m_rotationAxisCoordinates);
            bw.WriteBoolean(m_isAdditive);
            bw.Position += 5;
            s.WriteVoidArray(bw);
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_axisOfRotation = xd.ReadVector4(xe, nameof(m_axisOfRotation));
            m_twistAngle = xd.ReadSingle(xe, nameof(m_twistAngle));
            m_startBoneIndex = xd.ReadInt16(xe, nameof(m_startBoneIndex));
            m_endBoneIndex = xd.ReadInt16(xe, nameof(m_endBoneIndex));
            m_setAngleMethod = xd.ReadFlag<SetAngleMethod, sbyte>(xe, nameof(m_setAngleMethod));
            m_rotationAxisCoordinates = xd.ReadFlag<RotationAxisCoordinates, sbyte>(xe, nameof(m_rotationAxisCoordinates));
            m_isAdditive = xd.ReadBoolean(xe, nameof(m_isAdditive));
            m_boneChainIndices = default;
            m_parentBoneIndices = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_axisOfRotation), m_axisOfRotation);
            xs.WriteFloat(xe, nameof(m_twistAngle), m_twistAngle);
            xs.WriteNumber(xe, nameof(m_startBoneIndex), m_startBoneIndex);
            xs.WriteNumber(xe, nameof(m_endBoneIndex), m_endBoneIndex);
            xs.WriteEnum<SetAngleMethod, sbyte>(xe, nameof(m_setAngleMethod), m_setAngleMethod);
            xs.WriteEnum<RotationAxisCoordinates, sbyte>(xe, nameof(m_rotationAxisCoordinates), m_rotationAxisCoordinates);
            xs.WriteBoolean(xe, nameof(m_isAdditive), m_isAdditive);
            xs.WriteSerializeIgnored(xe, nameof(m_boneChainIndices));
            xs.WriteSerializeIgnored(xe, nameof(m_parentBoneIndices));
        }
    }
}

