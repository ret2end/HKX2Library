namespace HKX2
{
    public class hkpVehicleFrictionDescription : hkReferencedObject
    {
        public hkpVehicleFrictionDescriptionAxisDescription m_axleDescr_0;
        public hkpVehicleFrictionDescriptionAxisDescription m_axleDescr_1;
        public float m_chassisMassInv;

        public float m_wheelDistance;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_wheelDistance = br.ReadSingle();
            m_chassisMassInv = br.ReadSingle();
            m_axleDescr_0 = new hkpVehicleFrictionDescriptionAxisDescription();
            m_axleDescr_0.Read(des, br);
            m_axleDescr_1 = new hkpVehicleFrictionDescriptionAxisDescription();
            m_axleDescr_1.Read(des, br);
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_wheelDistance);
            bw.WriteSingle(m_chassisMassInv);
            m_axleDescr_0.Write(s, bw);
            m_axleDescr_1.Write(s, bw);
            bw.WriteUInt32(0);
        }
    }
}