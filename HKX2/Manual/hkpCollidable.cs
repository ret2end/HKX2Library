namespace HKX2
{
    public class hkpCollidable : hkpCdBody
    {
        public float m_allowedPenetrationDepth;
        public hkpTypedBroadPhaseHandle m_broadPhaseHandle;

        public byte m_forceCollideOntoPpu;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadByte(); // ownerOffset
            m_forceCollideOntoPpu = br.ReadByte();
            br.ReadUInt16(); // shapeSizeOnSpu
            m_broadPhaseHandle = new hkpTypedBroadPhaseHandle();
            m_broadPhaseHandle.Read(des, br);
            new hkpCollidableBoundingVolumeData().Read(des, br);
            m_allowedPenetrationDepth = br.ReadSingle();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(0); // ownerOffset
            bw.WriteByte(m_forceCollideOntoPpu);
            bw.WriteUInt16(0); // shapeSizeOnSpu
            m_broadPhaseHandle.Write(s, bw);
            new hkpCollidableBoundingVolumeData().Write(s, bw);
            bw.WriteSingle(m_allowedPenetrationDepth);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}