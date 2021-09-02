namespace HKX2
{
    public class hkpVehicleDefaultSimulation : hkpVehicleSimulation
    {
        public hkpVehicleFrictionDescription m_frictionDescription;

        public hkpVehicleFrictionStatus m_frictionStatus;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_frictionStatus = new hkpVehicleFrictionStatus();
            m_frictionStatus.Read(des, br);
            br.ReadUInt32();
            m_frictionDescription = des.ReadClassPointer<hkpVehicleFrictionDescription>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_frictionStatus.Write(s, bw);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_frictionDescription);
        }
    }
}