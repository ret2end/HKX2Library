using System.Collections.Generic;

namespace HKX2
{
    public class hkpVehicleSteeringAckerman : hkpVehicleSteering
    {
        public List<bool> m_doesWheelSteer;
        public float m_maxSpeedFullSteeringAngle;

        public float m_maxSteeringAngle;
        public float m_trackWidth;
        public float m_wheelBaseLength;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_maxSteeringAngle = br.ReadSingle();
            m_maxSpeedFullSteeringAngle = br.ReadSingle();
            br.ReadUInt32();
            m_doesWheelSteer = des.ReadBooleanArray(br);
            m_trackWidth = br.ReadSingle();
            m_wheelBaseLength = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_maxSteeringAngle);
            bw.WriteSingle(m_maxSpeedFullSteeringAngle);
            bw.WriteUInt32(0);
            s.WriteBooleanArray(bw, m_doesWheelSteer);
            bw.WriteSingle(m_trackWidth);
            bw.WriteSingle(m_wheelBaseLength);
        }
    }
}