using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSkeletonMapperDataChainMapping Signatire: 0xa528f7cf size: 112 flags: FLAGS_NONE

    // m_startBoneA m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_endBoneA m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_startBoneB m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_endBoneB m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 6 flags:  enum: 
    // m_startAFromBTransform m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_endAFromBTransform m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkaSkeletonMapperDataChainMapping : IHavokObject
    {

        public short m_startBoneA;
        public short m_endBoneA;
        public short m_startBoneB;
        public short m_endBoneB;
        public Matrix4x4 m_startAFromBTransform;
        public Matrix4x4 m_endAFromBTransform;

        public uint Signature => 0xa528f7cf;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_startBoneA = br.ReadInt16();
            m_endBoneA = br.ReadInt16();
            m_startBoneB = br.ReadInt16();
            m_endBoneB = br.ReadInt16();
            br.Position += 8;
            m_startAFromBTransform = des.ReadQSTransform(br);
            m_endAFromBTransform = des.ReadQSTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt16(m_startBoneA);
            bw.WriteInt16(m_endBoneA);
            bw.WriteInt16(m_startBoneB);
            bw.WriteInt16(m_endBoneB);
            bw.Position += 8;
            s.WriteQSTransform(bw, m_startAFromBTransform);
            s.WriteQSTransform(bw, m_endAFromBTransform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

