using System.Collections.Generic;

namespace HKX2
{
    public class hkpVehicleDefaultTransmission : hkpVehicleTransmission
    {
        public float m_clutchDelayTime;

        public float m_downshiftRPM;
        public List<float> m_gearsRatio;
        public float m_primaryTransmissionRatio;
        public float m_reverseGearRatio;
        public float m_upshiftRPM;
        public List<float> m_wheelsTorqueRatio;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_downshiftRPM = br.ReadSingle();
            m_upshiftRPM = br.ReadSingle();
            m_primaryTransmissionRatio = br.ReadSingle();
            m_clutchDelayTime = br.ReadSingle();
            m_reverseGearRatio = br.ReadSingle();
            m_gearsRatio = des.ReadSingleArray(br);
            m_wheelsTorqueRatio = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_downshiftRPM);
            bw.WriteSingle(m_upshiftRPM);
            bw.WriteSingle(m_primaryTransmissionRatio);
            bw.WriteSingle(m_clutchDelayTime);
            bw.WriteSingle(m_reverseGearRatio);
            s.WriteSingleArray(bw, m_gearsRatio);
            s.WriteSingleArray(bw, m_wheelsTorqueRatio);
        }
    }
}