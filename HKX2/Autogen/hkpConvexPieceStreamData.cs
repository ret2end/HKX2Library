using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexPieceStreamData Signatire: 0xa5bd1d6e size: 64 flags: FLAGS_NONE

    // m_convexPieceStream m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 16 flags:  enum: 
    // m_convexPieceOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 32 flags:  enum: 
    // m_convexPieceSingleTriangles m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpConvexPieceStreamData : hkReferencedObject
    {

        public List<uint> m_convexPieceStream;
        public List<uint> m_convexPieceOffsets;
        public List<uint> m_convexPieceSingleTriangles;

        public override uint Signature => 0xa5bd1d6e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_convexPieceStream = des.ReadUInt32Array(br);
            m_convexPieceOffsets = des.ReadUInt32Array(br);
            m_convexPieceSingleTriangles = des.ReadUInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_convexPieceStream);
            s.WriteUInt32Array(bw, m_convexPieceOffsets);
            s.WriteUInt32Array(bw, m_convexPieceSingleTriangles);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

