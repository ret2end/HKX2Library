namespace HKX2
{
    public enum ResponseType
    {
        RESPONSE_INVALID = 0,
        RESPONSE_SIMPLE_CONTACT = 1,
        RESPONSE_REPORTING = 2,
        RESPONSE_NONE = 3,
        RESPONSE_MAX_ID = 4
    }

    public class hkpMaterial : IHavokObject
    {
        public float m_friction;

        public ResponseType m_responseType;
        public float m_restitution;
        public short m_rollingFrictionMultiplier;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_responseType = (ResponseType) br.ReadSByte();
            br.ReadByte();
            m_rollingFrictionMultiplier = br.ReadInt16();
            m_friction = br.ReadSingle();
            m_restitution = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSByte((sbyte) m_responseType);
            bw.WriteByte(0);
            bw.WriteInt16(m_rollingFrictionMultiplier);
            bw.WriteSingle(m_friction);
            bw.WriteSingle(m_restitution);
        }
    }
}