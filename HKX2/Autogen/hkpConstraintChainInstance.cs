using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintChainInstance Signatire: 0x7a490753 size: 136 flags: FLAGS_NONE

    // m_chainedEntities m_class: hkpEntity Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 112 flags:  enum: 
    // m_action m_class: hkpConstraintChainInstanceAction Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 128 flags:  enum: 
    
    public class hkpConstraintChainInstance : hkpConstraintInstance
    {

        public List<hkpEntity> m_chainedEntities;
        public hkpConstraintChainInstanceAction /*pointer struct*/ m_action;

        public override uint Signature => 0x7a490753;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_chainedEntities = des.ReadClassPointerArray<hkpEntity>(br);
            m_action = des.ReadClassPointer<hkpConstraintChainInstanceAction>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpEntity>(bw, m_chainedEntities);
            s.WriteClassPointer(bw, m_action);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

