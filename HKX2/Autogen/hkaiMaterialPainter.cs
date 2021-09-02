namespace HKX2
{
    public class hkaiMaterialPainter : hkReferencedObject
    {
        public int m_material;
        public hkaiVolume m_volume;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_material = br.ReadInt32();
            m_volume = des.ReadClassPointer<hkaiVolume>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_material);
            s.WriteClassPointer(bw, m_volume);
        }
    }
}