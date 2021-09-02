namespace HKX2
{
    public class hclClothStateBufferAccess : IHavokObject
    {
        public uint m_bufferIndex;
        public hclBufferUsage m_bufferUsage;
        public uint m_shadowBufferIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_bufferIndex = br.ReadUInt32();
            m_bufferUsage = new hclBufferUsage();
            m_bufferUsage.Read(des, br);
            br.ReadByte();
            br.ReadUInt16();
            m_shadowBufferIndex = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_bufferIndex);
            m_bufferUsage.Write(s, bw);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
            bw.WriteUInt32(m_shadowBufferIndex);
        }
    }
}