namespace HKX2
{
    public class hkpVehicleRayCastWheelCollide : hkpVehicleWheelCollide
    {
        public hkpAabbPhantom m_phantom;
        public hkpRejectChassisListener m_rejectRayChassisListener;

        public uint m_wheelCollisionFilterInfo;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_wheelCollisionFilterInfo = br.ReadUInt32();
            br.ReadUInt32();
            m_phantom = des.ReadClassPointer<hkpAabbPhantom>(br);
            m_rejectRayChassisListener = new hkpRejectChassisListener();
            m_rejectRayChassisListener.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_wheelCollisionFilterInfo);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_phantom);
            m_rejectRayChassisListener.Write(s, bw);
        }
    }
}