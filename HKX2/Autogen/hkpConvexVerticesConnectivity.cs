using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexVerticesConnectivity Signatire: 0x63d38e9c size: 48 flags: FLAGS_NONE

    // m_vertexIndices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 16 flags:  enum: 
    // m_numVerticesPerFace m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpConvexVerticesConnectivity : hkReferencedObject
    {

        public List<ushort> m_vertexIndices;
        public List<byte> m_numVerticesPerFace;

        public override uint Signature => 0x63d38e9c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_vertexIndices = des.ReadUInt16Array(br);
            m_numVerticesPerFace = des.ReadByteArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_vertexIndices);
            s.WriteByteArray(bw, m_numVerticesPerFace);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

