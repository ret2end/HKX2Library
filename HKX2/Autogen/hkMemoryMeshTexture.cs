using System.Collections.Generic;

namespace HKX2
{
    public class hkMemoryMeshTexture : hkMeshTexture
    {
        public List<byte> m_data;

        public string m_filename;
        public FilterMode m_filterMode;
        public Format m_format;
        public bool m_hasMipMaps;
        public int m_textureCoordChannel;
        public TextureUsageType m_usageHint;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_filename = des.ReadStringPointer(br);
            m_data = des.ReadByteArray(br);
            m_format = (Format) br.ReadSByte();
            m_hasMipMaps = br.ReadBoolean();
            m_filterMode = (FilterMode) br.ReadSByte();
            m_usageHint = (TextureUsageType) br.ReadSByte();
            m_textureCoordChannel = br.ReadInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_filename);
            s.WriteByteArray(bw, m_data);
            bw.WriteSByte((sbyte) m_format);
            bw.WriteBoolean(m_hasMipMaps);
            bw.WriteSByte((sbyte) m_filterMode);
            bw.WriteSByte((sbyte) m_usageHint);
            bw.WriteInt32(m_textureCoordChannel);
        }
    }
}