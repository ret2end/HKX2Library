using System.Collections.Generic;

namespace HKX2
{
    public class hkpVehicleDefaultBrake : hkpVehicleBrake
    {
        public List<hkpVehicleDefaultBrakeWheelBrakingProperties> m_wheelBrakingProperties;
        public float m_wheelsMinTimeToBlock;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_wheelBrakingProperties = des.ReadClassArray<hkpVehicleDefaultBrakeWheelBrakingProperties>(br);
            m_wheelsMinTimeToBlock = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_wheelBrakingProperties);
            bw.WriteSingle(m_wheelsMinTimeToBlock);
            bw.WriteUInt32(0);
        }
    }
}