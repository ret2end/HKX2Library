namespace HKX2
{
    public enum FlagEnum
    {
        CONTACT_IS_NEW = 1,
        CONTACT_USES_SOLVER_PATH2 = 2,
        CONTACT_BREAKOFF_OBJECT_ID_SMALLER = 4,
        CONTACT_IS_DISABLED = 8
    }

    public class hkContactPointMaterial : IHavokObject
    {
        public byte m_flags;
        public hkUFloat8 m_friction;
        public hkUFloat8 m_maxImpulse;
        public byte m_restitution;

        public ulong m_userData;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_userData = br.ReadUInt64();
            m_friction = new hkUFloat8();
            m_friction.Read(des, br);
            m_restitution = br.ReadByte();
            m_maxImpulse = new hkUFloat8();
            m_maxImpulse.Read(des, br);
            m_flags = br.ReadByte();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_userData);
            m_friction.Write(s, bw);
            bw.WriteByte(m_restitution);
            m_maxImpulse.Write(s, bw);
            bw.WriteByte(m_flags);
            bw.WriteUInt32(0);
        }
    }
}