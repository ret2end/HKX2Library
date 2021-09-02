namespace HKX2
{
    public enum BroadPhaseType
    {
        BROAD_PHASE_INVALID = 0,
        BROAD_PHASE_ENTITY = 1,
        BROAD_PHASE_PHANTOM = 2,
        BROAD_PHASE_BORDER = 3,
        BROAD_PHASE_MAX_ID = 4
    }

    public class hkpTypedBroadPhaseHandle : hkpBroadPhaseHandle
    {
        public uint m_collisionFilterInfo;
        public sbyte m_objectQualityType;

        public BroadPhaseType m_type;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = (BroadPhaseType) br.ReadSByte();
            br.ReadByte(); // ownerOffset
            m_objectQualityType = br.ReadSByte();
            br.ReadByte();
            m_collisionFilterInfo = br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSByte((sbyte) m_type);
            bw.WriteByte(0); // ownerOffset
            bw.WriteSByte(m_objectQualityType);
            bw.WriteByte(0);
            bw.WriteUInt32(m_collisionFilterInfo);
        }
    }
}