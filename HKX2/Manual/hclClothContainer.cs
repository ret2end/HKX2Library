using System.Collections.Generic;

namespace HKX2
{
    public class hclClothContainer : hkReferencedObject
    {
        public List<hclClothData> m_clothDatas;

        public List<hclCollidable> m_collidables;
        public override uint Signature => 0x3512912B;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_collidables = des.ReadClassPointerArray<hclCollidable>(br);
            m_clothDatas = des.ReadClassPointerArray<hclClothData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_collidables);
            s.WriteClassPointerArray(bw, m_clothDatas);
        }
    }
}