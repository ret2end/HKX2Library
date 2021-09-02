using System.Collections.Generic;

namespace HKX2
{
    public class StaticCompoundInfo : IHavokObject
    {
        public List<ActorInfo> m_ActorInfo;

        public uint m_Offset;
        public List<ShapeInfo> m_ShapeInfo;
        public virtual uint Signature => 0x5115A202;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_Offset = br.ReadUInt32();
            m_ActorInfo = des.ReadClassArray<ActorInfo>(br);
            m_ShapeInfo = des.ReadClassArray<ShapeInfo>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_Offset);
            s.WriteClassArray(bw, m_ActorInfo);
            s.WriteClassArray(bw, m_ShapeInfo);
        }
    }
}