namespace HKX2
{
    public class hkpVehicleCastBatchingManager : hkpVehicleManager
    {
        public ushort m_totalNumWheels;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_totalNumWheels = br.ReadUInt16();
            br.ReadUInt32();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt16(m_totalNumWheels);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
        }
    }
}