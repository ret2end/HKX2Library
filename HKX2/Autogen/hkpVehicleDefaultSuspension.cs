using System.Collections.Generic;

namespace HKX2
{
    public class hkpVehicleDefaultSuspension : hkpVehicleSuspension
    {
        public List<hkpVehicleDefaultSuspensionWheelSpringSuspensionParameters> m_wheelSpringParams;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_wheelSpringParams = des.ReadClassArray<hkpVehicleDefaultSuspensionWheelSpringSuspensionParameters>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_wheelSpringParams);
        }
    }
}