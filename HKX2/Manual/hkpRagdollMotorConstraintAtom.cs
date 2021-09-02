using System.Numerics;

namespace HKX2
{
    public class hkpRagdollMotorConstraintAtom : hkpConstraintAtom
    {
        public bool m_isEnabled;
        public hkpConstraintMotor m_motors_0;
        public hkpConstraintMotor m_motors_1;
        public hkpConstraintMotor m_motors_2;
        public Matrix4x4 m_target_bRca;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadBoolean();
            br.ReadByte();
            br.ReadInt16(); // initializedOffset
            br.ReadInt16(); // previousTargetAnglesOffset
            br.Pad(16);
            m_target_bRca = des.ReadMatrix3(br);
            m_motors_0 = des.ReadClassPointer<hkpConstraintMotor>(br);
            m_motors_1 = des.ReadClassPointer<hkpConstraintMotor>(br);
            m_motors_2 = des.ReadClassPointer<hkpConstraintMotor>(br);
            br.ReadUSize();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_isEnabled);
            bw.WriteByte(0);
            bw.WriteInt16(0); // initializedOffset
            bw.WriteInt16(0); // previousTargetAnglesOffset
            bw.Pad(16);
            s.WriteMatrix3(bw, m_target_bRca);
            s.WriteClassPointer(bw, m_motors_0);
            s.WriteClassPointer(bw, m_motors_1);
            s.WriteClassPointer(bw, m_motors_2);
            bw.WriteUSize(0);
        }
    }
}