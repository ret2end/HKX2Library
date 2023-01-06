using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpConvexPieceStreamData Signatire: 0xa5bd1d6e size: 64 flags: FLAGS_NONE

    // m_convexPieceStream m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_convexPieceOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_convexPieceSingleTriangles m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpConvexPieceStreamData : hkReferencedObject
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
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_convexPieceStream);
            s.WriteUInt32Array(bw, m_convexPieceOffsets);
            s.WriteUInt32Array(bw, m_convexPieceSingleTriangles);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_convexPieceStream = xd.ReadUInt32Array(xe, nameof(m_convexPieceStream));
            m_convexPieceOffsets = xd.ReadUInt32Array(xe, nameof(m_convexPieceOffsets));
            m_convexPieceSingleTriangles = xd.ReadUInt32Array(xe, nameof(m_convexPieceSingleTriangles));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_convexPieceStream), m_convexPieceStream);
            xs.WriteNumberArray(xe, nameof(m_convexPieceOffsets), m_convexPieceOffsets);
            xs.WriteNumberArray(xe, nameof(m_convexPieceSingleTriangles), m_convexPieceSingleTriangles);
        }
    }
}

