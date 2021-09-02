namespace HKX2
{
    public class hkpBreakableMaterial : hkReferencedObject
    {
        public hkRefCountedProperties m_properties;

        public float m_strength;
        public int m_typeAndFlags;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_strength = br.ReadSingle();
            m_typeAndFlags = br.ReadInt32();
            br.ReadUInt32();
            m_properties = des.ReadClassPointer<hkRefCountedProperties>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_strength);
            bw.WriteInt32(m_typeAndFlags);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_properties);
        }
    }
}