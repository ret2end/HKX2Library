using System.Collections.Generic;

namespace HKX2
{
    public class hkpConvexPieceStreamData : hkReferencedObject
    {
        public List<uint> m_convexPieceOffsets;
        public List<uint> m_convexPieceSingleTriangles;

        public List<uint> m_convexPieceStream;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_convexPieceStream = des.ReadUInt32Array(br);
            m_convexPieceOffsets = des.ReadUInt32Array(br);
            m_convexPieceSingleTriangles = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_convexPieceStream);
            s.WriteUInt32Array(bw, m_convexPieceOffsets);
            s.WriteUInt32Array(bw, m_convexPieceSingleTriangles);
        }
    }
}