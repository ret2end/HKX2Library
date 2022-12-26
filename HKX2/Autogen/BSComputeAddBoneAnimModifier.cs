using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSComputeAddBoneAnimModifier Signatire: 0xa67f8c46 size: 160 flags: FLAGS_NONE

    // m_boneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_translationLSOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_rotationLSOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_scaleLSOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_pSkeletonMemory m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSComputeAddBoneAnimModifier : hkbModifier
    {

        public short m_boneIndex;
        public Vector4 m_translationLSOut;
        public Quaternion m_rotationLSOut;
        public Vector4 m_scaleLSOut;
        public dynamic /* POINTER VOID */ m_pSkeletonMemory;

        public override uint Signature => 0xa67f8c46;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_boneIndex = br.ReadInt16();
            br.Position += 14;
            m_translationLSOut = br.ReadVector4();
            m_rotationLSOut = des.ReadQuaternion(br);
            m_scaleLSOut = br.ReadVector4();
            des.ReadEmptyPointer(br);/* m_pSkeletonMemory POINTER VOID */
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt16(m_boneIndex);
            bw.Position += 14;
            bw.WriteVector4(m_translationLSOut);
            s.WriteQuaternion(bw, m_rotationLSOut);
            bw.WriteVector4(m_scaleLSOut);
            s.WriteVoidPointer(bw);/* m_pSkeletonMemory POINTER VOID */
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

