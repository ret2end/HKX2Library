namespace HKX2
{
    public class hkpWheelFrictionConstraintAtom : hkpConstraintAtom
    {
        public hkpWheelFrictionConstraintAtomAxle m_axle;
        public byte m_forwardAxis;
        public float m_frictionImpulse_0;
        public float m_frictionImpulse_1;

        public byte m_isEnabled;
        public float m_maxFrictionForce;
        public float m_radius;
        public byte m_sideAxis;
        public float m_slipImpulse_0;
        public float m_slipImpulse_1;
        public float m_torque;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_forwardAxis = br.ReadByte();
            m_sideAxis = br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_radius = br.ReadSingle();
            br.ReadUInt32();
            m_axle = des.ReadClassPointer<hkpWheelFrictionConstraintAtomAxle>(br);
            br.ReadUInt64();
            m_maxFrictionForce = br.ReadSingle();
            m_torque = br.ReadSingle();
            m_frictionImpulse_0 = br.ReadSingle();
            m_frictionImpulse_1 = br.ReadSingle();
            m_slipImpulse_0 = br.ReadSingle();
            m_slipImpulse_1 = br.ReadSingle();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_forwardAxis);
            bw.WriteByte(m_sideAxis);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_radius);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_axle);
            bw.WriteUInt64(0);
            bw.WriteSingle(m_maxFrictionForce);
            bw.WriteSingle(m_torque);
            bw.WriteSingle(m_frictionImpulse_0);
            bw.WriteSingle(m_frictionImpulse_1);
            bw.WriteSingle(m_slipImpulse_0);
            bw.WriteSingle(m_slipImpulse_1);
            bw.WriteUInt64(0);
        }
    }
}