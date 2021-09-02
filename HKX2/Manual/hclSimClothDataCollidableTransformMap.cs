using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclSimClothDataCollidableTransformMap : IHavokObject
    {
        public List<Matrix4x4> m_offsets;
        public List<uint> m_transformIndices;

        public int m_transformSetIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transformSetIndex = br.ReadInt32();
            m_transformIndices = des.ReadUInt32Array(br);
            m_offsets = des.ReadMatrix4Array(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_transformSetIndex);
            s.WriteUInt32Array(bw, m_transformIndices);
            s.WriteMatrix4Array(bw, m_offsets);
        }
    }
}