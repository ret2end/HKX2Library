using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxEdgeSelectionChannel Signatire: 0x9ad32a5e size: 32 flags: FLAGS_NONE

    // m_selectedEdges m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxEdgeSelectionChannel : hkReferencedObject
    {

        public List<int> m_selectedEdges;

        public override uint Signature => 0x9ad32a5e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_selectedEdges = des.ReadInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt32Array(bw, m_selectedEdges);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

