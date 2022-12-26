using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSkeletonLocalFrameOnBone Signatire: 0x52e8043 size: 16 flags: FLAGS_NONE

    // m_localFrame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_boneIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkaSkeletonLocalFrameOnBone : IHavokObject
    {

        public hkLocalFrame /*pointer struct*/ m_localFrame;
        public int m_boneIndex;

        public uint Signature => 0x52e8043;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_localFrame = des.ReadClassPointer<hkLocalFrame>(br);
            m_boneIndex = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_localFrame);
            bw.WriteInt32(m_boneIndex);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

