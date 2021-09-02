using System.Collections.Generic;

namespace HKX2
{
    public class hkxVertexAnimation : hkReferencedObject
    {
        public List<hkxVertexAnimationUsageMap> m_componentMap;

        public float m_time;
        public hkxVertexBuffer m_vertData;
        public List<int> m_vertexIndexMap;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_time = br.ReadSingle();
            m_vertData = new hkxVertexBuffer();
            m_vertData.Read(des, br);
            m_vertexIndexMap = des.ReadInt32Array(br);
            m_componentMap = des.ReadClassArray<hkxVertexAnimationUsageMap>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_time);
            m_vertData.Write(s, bw);
            s.WriteInt32Array(bw, m_vertexIndexMap);
            s.WriteClassArray(bw, m_componentMap);
        }
    }
}