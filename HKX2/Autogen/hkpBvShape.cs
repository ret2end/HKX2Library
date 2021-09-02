namespace HKX2
{
    public class hkpBvShape : hkpShape
    {
        public hkpShape m_boundingVolumeShape;
        public hkpSingleShapeContainer m_childShape;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_boundingVolumeShape = des.ReadClassPointer<hkpShape>(br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_boundingVolumeShape);
            m_childShape.Write(s, bw);
        }
    }
}