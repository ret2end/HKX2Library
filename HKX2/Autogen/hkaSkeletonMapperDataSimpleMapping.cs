using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSkeletonMapperDataSimpleMapping Signatire: 0x3405deca size: 64 flags: FLAGS_NONE

    // m_boneA m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_boneB m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_aFromBTransform m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkaSkeletonMapperDataSimpleMapping : IHavokObject
    {

        public short m_boneA;
        public short m_boneB;
        public Matrix4x4 m_aFromBTransform;

        public uint Signature => 0x3405deca;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_boneA = br.ReadInt16();
            m_boneB = br.ReadInt16();
            br.Position += 12;
            m_aFromBTransform = des.ReadQSTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt16(m_boneA);
            bw.WriteInt16(m_boneB);
            bw.Position += 12;
            s.WriteQSTransform(bw, m_aFromBTransform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

