using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxTriangleSelectionChannel Signatire: 0xa02cfca9 size: 32 flags: FLAGS_NONE

    // m_selectedTriangles m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxTriangleSelectionChannel : hkReferencedObject
    {

        public List<int> m_selectedTriangles;

        public override uint Signature => 0xa02cfca9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_selectedTriangles = des.ReadInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt32Array(bw, m_selectedTriangles);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

