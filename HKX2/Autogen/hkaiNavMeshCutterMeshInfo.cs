using System.Collections.Generic;

namespace HKX2
{
    public class hkaiNavMeshCutterMeshInfo : IHavokObject
    {
        public List<int> m_faceMapping;
        public int m_originalNumEdges;

        public int m_originalNumFaces;
        public int m_originalNumVertices;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_originalNumFaces = br.ReadInt32();
            m_originalNumEdges = br.ReadInt32();
            m_originalNumVertices = br.ReadInt32();
            br.ReadUInt32();
            m_faceMapping = des.ReadInt32Array(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_originalNumFaces);
            bw.WriteInt32(m_originalNumEdges);
            bw.WriteInt32(m_originalNumVertices);
            bw.WriteUInt32(0);
            s.WriteInt32Array(bw, m_faceMapping);
        }
    }
}