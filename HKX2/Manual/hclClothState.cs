using System.Collections.Generic;

namespace HKX2
{
    public class hclClothState : hkReferencedObject
    {
        public string m_name;
        public List<uint> m_operators;
        public List<hclClothStateBufferAccess> m_usedBuffers;
        public List<uint> m_usedSimCloths;
        public List<hclClothStateTransformSetAccess> m_usedTransformSets;
        public override uint Signature => 0x7B02CD1B;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_operators = des.ReadUInt32Array(br);
            m_usedBuffers = des.ReadClassArray<hclClothStateBufferAccess>(br);
            m_usedTransformSets = des.ReadClassArray<hclClothStateTransformSetAccess>(br);
            m_usedSimCloths = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteUInt32Array(bw, m_operators);
            s.WriteClassArray(bw, m_usedBuffers);
            s.WriteClassArray(bw, m_usedTransformSets);
            s.WriteUInt32Array(bw, m_usedSimCloths);
        }
    }
}