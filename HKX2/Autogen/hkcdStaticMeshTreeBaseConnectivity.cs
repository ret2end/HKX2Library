using System.Collections.Generic;

namespace HKX2
{
    public class hkcdStaticMeshTreeBaseConnectivity : IHavokObject
    {
        public List<uint> m_globalLinks;

        public List<hkcdStaticMeshTreeBaseConnectivitySectionHeader> m_headers;
        public List<byte> m_localLinks;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_headers = des.ReadClassArray<hkcdStaticMeshTreeBaseConnectivitySectionHeader>(br);
            m_localLinks = des.ReadByteArray(br);
            m_globalLinks = des.ReadUInt32Array(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_headers);
            s.WriteByteArray(bw, m_localLinks);
            s.WriteUInt32Array(bw, m_globalLinks);
        }
    }
}