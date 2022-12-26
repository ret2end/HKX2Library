using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexSelectionChannel Signatire: 0x866ec6d0 size: 32 flags: FLAGS_NONE

    // m_selectedVertices m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxVertexSelectionChannel : hkReferencedObject
    {

        public List<int> m_selectedVertices;

        public override uint Signature => 0x866ec6d0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_selectedVertices = des.ReadInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt32Array(bw, m_selectedVertices);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

