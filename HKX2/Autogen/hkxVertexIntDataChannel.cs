using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexIntDataChannel Signatire: 0x5a50e673 size: 32 flags: FLAGS_NONE

    // m_perVertexInts m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxVertexIntDataChannel : hkReferencedObject
    {

        public List<int> m_perVertexInts;

        public override uint Signature => 0x5a50e673;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_perVertexInts = des.ReadInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt32Array(bw, m_perVertexInts);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

