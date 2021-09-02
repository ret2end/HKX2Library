using System.Collections.Generic;

namespace HKX2
{
    public class hclBonePlanesConstraintSet : hclConstraintSet
    {
        public List<hclBonePlanesConstraintSetBonePlane> m_bonePlanes;
        public uint m_transformSetIndex;
        public override uint Signature => 0x5AC4C7C9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bonePlanes = des.ReadClassArray<hclBonePlanesConstraintSetBonePlane>(br);
            m_transformSetIndex = br.ReadUInt32();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_bonePlanes);
            bw.WriteUInt32(m_transformSetIndex);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}