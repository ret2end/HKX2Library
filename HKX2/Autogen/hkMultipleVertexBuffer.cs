using System.Collections.Generic;

namespace HKX2
{
    public class hkMultipleVertexBuffer : hkMeshVertexBuffer
    {
        public bool m_constructionComplete;
        public List<hkMultipleVertexBufferElementInfo> m_elementInfos;
        public bool m_isLocked;
        public bool m_isSharable;
        public hkMemoryMeshVertexBuffer m_lockedBuffer;
        public List<hkMultipleVertexBufferLockedElement> m_lockedElements;
        public int m_numVertices;
        public uint m_updateCount;
        public List<hkMultipleVertexBufferVertexBufferInfo> m_vertexBufferInfos;

        public hkVertexFormat m_vertexFormat;
        public bool m_writeLock;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexFormat = new hkVertexFormat();
            m_vertexFormat.Read(des, br);
            m_lockedElements = des.ReadClassArray<hkMultipleVertexBufferLockedElement>(br);
            m_lockedBuffer = des.ReadClassPointer<hkMemoryMeshVertexBuffer>(br);
            m_elementInfos = des.ReadClassArray<hkMultipleVertexBufferElementInfo>(br);
            m_vertexBufferInfos = des.ReadClassArray<hkMultipleVertexBufferVertexBufferInfo>(br);
            m_numVertices = br.ReadInt32();
            m_isLocked = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_updateCount = br.ReadUInt32();
            m_writeLock = br.ReadBoolean();
            m_isSharable = br.ReadBoolean();
            m_constructionComplete = br.ReadBoolean();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_vertexFormat.Write(s, bw);
            s.WriteClassArray(bw, m_lockedElements);
            s.WriteClassPointer(bw, m_lockedBuffer);
            s.WriteClassArray(bw, m_elementInfos);
            s.WriteClassArray(bw, m_vertexBufferInfos);
            bw.WriteInt32(m_numVertices);
            bw.WriteBoolean(m_isLocked);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteUInt32(m_updateCount);
            bw.WriteBoolean(m_writeLock);
            bw.WriteBoolean(m_isSharable);
            bw.WriteBoolean(m_constructionComplete);
            bw.WriteByte(0);
        }
    }
}