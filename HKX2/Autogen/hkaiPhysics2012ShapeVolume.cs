using System.Numerics;

namespace HKX2
{
    public class hkaiPhysics2012ShapeVolume : hkaiVolume
    {
        public hkGeometry m_geometry;

        public hkpShape m_shape;
        public Matrix4x4 m_shapeTransform;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_shapeTransform = des.ReadTransform(br);
            m_geometry = new hkGeometry();
            m_geometry.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteClassPointer(bw, m_shape);
            s.WriteTransform(bw, m_shapeTransform);
            m_geometry.Write(s, bw);
        }
    }
}