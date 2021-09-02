namespace HKX2
{
    public class hkpConvexPieceMeshShape : hkpShapeCollection
    {
        public hkpConvexPieceStreamData m_convexPieceStream;
        public hkpShapeCollection m_displayMesh;
        public float m_radius;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_convexPieceStream = des.ReadClassPointer<hkpConvexPieceStreamData>(br);
            m_displayMesh = des.ReadClassPointer<hkpShapeCollection>(br);
            m_radius = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_convexPieceStream);
            s.WriteClassPointer(bw, m_displayMesh);
            bw.WriteSingle(m_radius);
            bw.WriteUInt32(0);
        }
    }
}