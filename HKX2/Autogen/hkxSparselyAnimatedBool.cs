using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxSparselyAnimatedBool Signatire: 0x7a894596 size: 48 flags: FLAGS_NONE

    // m_bools m_class:  Type.TYPE_ARRAY Type.TYPE_BOOL arrSize: 0 offset: 16 flags:  enum: 
    // m_times m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkxSparselyAnimatedBool : hkReferencedObject
    {

        public List<bool> m_bools;
        public List<float> m_times;

        public override uint Signature => 0x7a894596;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_bools = des.ReadBooleanArray(br);
            m_times = des.ReadSingleArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteBooleanArray(bw, m_bools);
            s.WriteSingleArray(bw, m_times);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

