using System.Collections.Generic;

namespace HKX2
{
    public class hkMemoryMeshShape : hkMeshShape
    {
        public List<ushort> m_indices16;
        public List<uint> m_indices32;
        public string m_name;

        public List<hkMemoryMeshShapeSection> m_sections;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_sections = des.ReadClassArray<hkMemoryMeshShapeSection>(br);
            m_indices16 = des.ReadUInt16Array(br);
            m_indices32 = des.ReadUInt32Array(br);
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_sections);
            s.WriteUInt16Array(bw, m_indices16);
            s.WriteUInt32Array(bw, m_indices32);
            s.WriteStringPointer(bw, m_name);
        }
    }
}