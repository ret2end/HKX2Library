using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPoweredChainMapperLinkInfo Signatire: 0xcf071a1b size: 16 flags: FLAGS_NONE

    // m_firstTargetIdx m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_numTargets m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_limitConstraint m_class: hkpConstraintInstance Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpPoweredChainMapperLinkInfo : IHavokObject
    {

        public int m_firstTargetIdx;
        public int m_numTargets;
        public hkpConstraintInstance /*pointer struct*/ m_limitConstraint;

        public uint Signature => 0xcf071a1b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_firstTargetIdx = br.ReadInt32();
            m_numTargets = br.ReadInt32();
            m_limitConstraint = des.ReadClassPointer<hkpConstraintInstance>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_firstTargetIdx);
            bw.WriteInt32(m_numTargets);
            s.WriteClassPointer(bw, m_limitConstraint);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

