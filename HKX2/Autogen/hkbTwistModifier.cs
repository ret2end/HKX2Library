using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTwistModifier Signatire: 0xb6b76b32 size: 144 flags: FLAGS_NONE

    // m_axisOfRotation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_twistAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_startBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_endBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 102 flags:  enum: 
    // m_setAngleMethod m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 104 flags:  enum: SetAngleMethod
    // m_rotationAxisCoordinates m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 105 flags:  enum: RotationAxisCoordinates
    // m_isAdditive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 106 flags:  enum: 
    // m_boneChainIndices m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_parentBoneIndices m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 128 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbTwistModifier : hkbModifier
    {

        public Vector4 m_axisOfRotation;
        public float m_twistAngle;
        public short m_startBoneIndex;
        public short m_endBoneIndex;
        public sbyte m_setAngleMethod;
        public sbyte m_rotationAxisCoordinates;
        public bool m_isAdditive;
        public List<ulong> m_boneChainIndices;
        public List<ulong> m_parentBoneIndices;

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
            des.ReadEmptyArray(br); //m_boneChainIndices
            des.ReadEmptyArray(br); //m_parentBoneIndices

            // throw new NotImplementedException("code generated. check first");
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
            s.WriteVoidArray(bw); // m_boneChainIndices
            s.WriteVoidArray(bw); // m_parentBoneIndices

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

