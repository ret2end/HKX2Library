namespace HKX2
{
    public class hkaiCarver : hkReferencedObject
    {
        public enum FlagBits
        {
            CARVER_ERODE_EDGES = 1
        }

        public uint m_flags;

        public hkaiVolume m_volume;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_volume = des.ReadClassPointer<hkaiVolume>(br);
            m_flags = br.ReadUInt32();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_volume);
            bw.WriteUInt32(m_flags);
            bw.WriteUInt32(0);
        }
    }
}