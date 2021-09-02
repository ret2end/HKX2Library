namespace HKX2
{
    public class hkcdPlanarGeometry : hkcdPlanarEntity
    {
        public hkcdPlanarGeometryPlanesCollection m_planes;
        public hkcdPlanarGeometryPolygonCollection m_polys;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_planes = des.ReadClassPointer<hkcdPlanarGeometryPlanesCollection>(br);
            m_polys = des.ReadClassPointer<hkcdPlanarGeometryPolygonCollection>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_planes);
            s.WriteClassPointer(bw, m_polys);
            bw.WriteUInt64(0);
        }
    }
}