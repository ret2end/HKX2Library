namespace HKX2
{
    public class hclOutputConvertOperator : hclOperator
    {
        public hclRuntimeConversionInfo m_conversionInfo;
        public uint m_shadowBufferIndex;

        public uint m_userBufferIndex;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_userBufferIndex = br.ReadUInt32();
            m_shadowBufferIndex = br.ReadUInt32();
            m_conversionInfo = new hclRuntimeConversionInfo();
            m_conversionInfo.Read(des, br);
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_userBufferIndex);
            bw.WriteUInt32(m_shadowBufferIndex);
            m_conversionInfo.Write(s, bw);
            bw.WriteUInt16(0);
        }
    }
}