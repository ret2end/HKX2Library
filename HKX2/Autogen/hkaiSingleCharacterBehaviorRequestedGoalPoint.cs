using System.Numerics;

namespace HKX2
{
    public class hkaiSingleCharacterBehaviorRequestedGoalPoint : IHavokObject
    {
        public Vector4 m_position;
        public int m_sectionId;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_position = des.ReadVector4(br);
            m_sectionId = br.ReadInt32();
            br.ReadUInt64();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_position);
            bw.WriteInt32(m_sectionId);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
        }
    }
}