namespace HKX2
{
    public class hkMeshSectionCinfo : IHavokObject
    {
        public hkMeshBoneIndexMapping m_boneMatrixMap;
        public MeshSectionIndexType m_indexType;
        public hkMeshMaterial m_material;
        public int m_numPrimitives;
        public PrimitiveType m_primitiveType;
        public int m_transformIndex;

        public hkMeshVertexBuffer m_vertexBuffer;
        public int m_vertexStartIndex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_vertexBuffer = des.ReadClassPointer<hkMeshVertexBuffer>(br);
            m_material = des.ReadClassPointer<hkMeshMaterial>(br);
            m_boneMatrixMap = new hkMeshBoneIndexMapping();
            m_boneMatrixMap.Read(des, br);
            m_primitiveType = (PrimitiveType) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_numPrimitives = br.ReadInt32();
            m_indexType = (MeshSectionIndexType) br.ReadByte();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
            m_vertexStartIndex = br.ReadInt32();
            m_transformIndex = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_vertexBuffer);
            s.WriteClassPointer(bw, m_material);
            m_boneMatrixMap.Write(s, bw);
            bw.WriteByte((byte) m_primitiveType);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteInt32(m_numPrimitives);
            bw.WriteByte((byte) m_indexType);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteInt32(m_vertexStartIndex);
            bw.WriteInt32(m_transformIndex);
        }
    }
}