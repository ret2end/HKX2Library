using System.Collections.Generic;

namespace HKX2
{
    public class hkStorageSkinnedMeshShape : hkSkinnedMeshShape
    {
        public List<short> m_bonesBuffer;
        public List<hkSkinnedMeshShapeBoneSection> m_boneSections;
        public List<hkSkinnedMeshShapeBoneSet> m_boneSets;
        public string m_name;
        public List<hkSkinnedMeshShapePart> m_parts;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bonesBuffer = des.ReadInt16Array(br);
            m_boneSets = des.ReadClassArray<hkSkinnedMeshShapeBoneSet>(br);
            m_boneSections = des.ReadClassArray<hkSkinnedMeshShapeBoneSection>(br);
            m_parts = des.ReadClassArray<hkSkinnedMeshShapePart>(br);
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt16Array(bw, m_bonesBuffer);
            s.WriteClassArray(bw, m_boneSets);
            s.WriteClassArray(bw, m_boneSections);
            s.WriteClassArray(bw, m_parts);
            s.WriteStringPointer(bw, m_name);
        }
    }
}