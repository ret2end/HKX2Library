namespace HKX2
{
    public class hkpBreakableShape : hkReferencedObject
    {
        public hkpBreakableMaterial m_material;

        public hkcdShape m_physicsShape;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_physicsShape = des.ReadClassPointer<hkcdShape>(br);
            m_material = des.ReadClassPointer<hkpBreakableMaterial>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_physicsShape);
            s.WriteClassPointer(bw, m_material);
        }
    }
}