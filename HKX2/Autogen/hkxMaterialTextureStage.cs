namespace HKX2
{
    public class hkxMaterialTextureStage : IHavokObject
    {
        public int m_tcoordChannel;

        public hkReferencedObject m_texture;
        public TextureType m_usageHint;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_texture = des.ReadClassPointer<hkReferencedObject>(br);
            m_usageHint = (TextureType) br.ReadInt32();
            m_tcoordChannel = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_texture);
            bw.WriteInt32((int) m_usageHint);
            bw.WriteInt32(m_tcoordChannel);
        }
    }
}