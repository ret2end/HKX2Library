namespace HKX2
{
    public class hkpVehicleDefaultEngine : hkpVehicleEngine
    {
        public float m_clutchSlipRPM;
        public float m_maxRPM;
        public float m_maxTorque;

        public float m_minRPM;
        public float m_optRPM;
        public float m_resistanceFactorAtMaxRPM;
        public float m_resistanceFactorAtMinRPM;
        public float m_resistanceFactorAtOptRPM;
        public float m_torqueFactorAtMaxRPM;
        public float m_torqueFactorAtMinRPM;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_minRPM = br.ReadSingle();
            m_optRPM = br.ReadSingle();
            m_maxRPM = br.ReadSingle();
            m_maxTorque = br.ReadSingle();
            m_torqueFactorAtMinRPM = br.ReadSingle();
            m_torqueFactorAtMaxRPM = br.ReadSingle();
            m_resistanceFactorAtMinRPM = br.ReadSingle();
            m_resistanceFactorAtOptRPM = br.ReadSingle();
            m_resistanceFactorAtMaxRPM = br.ReadSingle();
            m_clutchSlipRPM = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_minRPM);
            bw.WriteSingle(m_optRPM);
            bw.WriteSingle(m_maxRPM);
            bw.WriteSingle(m_maxTorque);
            bw.WriteSingle(m_torqueFactorAtMinRPM);
            bw.WriteSingle(m_torqueFactorAtMaxRPM);
            bw.WriteSingle(m_resistanceFactorAtMinRPM);
            bw.WriteSingle(m_resistanceFactorAtOptRPM);
            bw.WriteSingle(m_resistanceFactorAtMaxRPM);
            bw.WriteSingle(m_clutchSlipRPM);
            bw.WriteUInt32(0);
        }
    }
}