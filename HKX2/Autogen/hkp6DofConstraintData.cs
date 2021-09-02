namespace HKX2
{
    public enum MotorIndex
    {
        MOTOR_TWIST = 0,
        MOTOR_SWING0 = 1,
        MOTOR_SWING1 = 2,
        MOTOR_ALL = 3
    }

    public class hkp6DofConstraintData : hkpConstraintData
    {
        public enum Axis
        {
            AXIS_TWIST = 0,
            AXIS_SWING0 = 1,
            AXIS_SWING1 = 2
        }

        public int m_atomToCompiledAtomOffset_0;
        public int m_atomToCompiledAtomOffset_1;
        public int m_atomToCompiledAtomOffset_10;
        public int m_atomToCompiledAtomOffset_2;
        public int m_atomToCompiledAtomOffset_3;
        public int m_atomToCompiledAtomOffset_4;
        public int m_atomToCompiledAtomOffset_5;
        public int m_atomToCompiledAtomOffset_6;
        public int m_atomToCompiledAtomOffset_7;
        public int m_atomToCompiledAtomOffset_8;
        public int m_atomToCompiledAtomOffset_9;

        public hkp6DofConstraintDataBlueprints m_blueprints;
        public bool m_isDirty;
        public int m_numRuntimeElements;
        public int m_resultToRuntime_0;
        public int m_resultToRuntime_1;
        public int m_resultToRuntime_10;
        public int m_resultToRuntime_11;
        public int m_resultToRuntime_12;
        public int m_resultToRuntime_13;
        public int m_resultToRuntime_14;
        public int m_resultToRuntime_15;
        public int m_resultToRuntime_16;
        public int m_resultToRuntime_17;
        public int m_resultToRuntime_18;
        public int m_resultToRuntime_2;
        public int m_resultToRuntime_3;
        public int m_resultToRuntime_4;
        public int m_resultToRuntime_5;
        public int m_resultToRuntime_6;
        public int m_resultToRuntime_7;
        public int m_resultToRuntime_8;
        public int m_resultToRuntime_9;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_blueprints = new hkp6DofConstraintDataBlueprints();
            m_blueprints.Read(des, br);
            m_isDirty = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_numRuntimeElements = br.ReadInt32();
            m_atomToCompiledAtomOffset_0 = br.ReadInt32();
            m_atomToCompiledAtomOffset_1 = br.ReadInt32();
            m_atomToCompiledAtomOffset_2 = br.ReadInt32();
            m_atomToCompiledAtomOffset_3 = br.ReadInt32();
            m_atomToCompiledAtomOffset_4 = br.ReadInt32();
            m_atomToCompiledAtomOffset_5 = br.ReadInt32();
            m_atomToCompiledAtomOffset_6 = br.ReadInt32();
            m_atomToCompiledAtomOffset_7 = br.ReadInt32();
            m_atomToCompiledAtomOffset_8 = br.ReadInt32();
            m_atomToCompiledAtomOffset_9 = br.ReadInt32();
            m_atomToCompiledAtomOffset_10 = br.ReadInt32();
            m_resultToRuntime_0 = br.ReadInt32();
            m_resultToRuntime_1 = br.ReadInt32();
            m_resultToRuntime_2 = br.ReadInt32();
            m_resultToRuntime_3 = br.ReadInt32();
            m_resultToRuntime_4 = br.ReadInt32();
            m_resultToRuntime_5 = br.ReadInt32();
            m_resultToRuntime_6 = br.ReadInt32();
            m_resultToRuntime_7 = br.ReadInt32();
            m_resultToRuntime_8 = br.ReadInt32();
            m_resultToRuntime_9 = br.ReadInt32();
            m_resultToRuntime_10 = br.ReadInt32();
            m_resultToRuntime_11 = br.ReadInt32();
            m_resultToRuntime_12 = br.ReadInt32();
            m_resultToRuntime_13 = br.ReadInt32();
            m_resultToRuntime_14 = br.ReadInt32();
            m_resultToRuntime_15 = br.ReadInt32();
            m_resultToRuntime_16 = br.ReadInt32();
            m_resultToRuntime_17 = br.ReadInt32();
            m_resultToRuntime_18 = br.ReadInt32();
            br.ReadUInt64();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_blueprints.Write(s, bw);
            bw.WriteBoolean(m_isDirty);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteInt32(m_numRuntimeElements);
            bw.WriteInt32(m_atomToCompiledAtomOffset_0);
            bw.WriteInt32(m_atomToCompiledAtomOffset_1);
            bw.WriteInt32(m_atomToCompiledAtomOffset_2);
            bw.WriteInt32(m_atomToCompiledAtomOffset_3);
            bw.WriteInt32(m_atomToCompiledAtomOffset_4);
            bw.WriteInt32(m_atomToCompiledAtomOffset_5);
            bw.WriteInt32(m_atomToCompiledAtomOffset_6);
            bw.WriteInt32(m_atomToCompiledAtomOffset_7);
            bw.WriteInt32(m_atomToCompiledAtomOffset_8);
            bw.WriteInt32(m_atomToCompiledAtomOffset_9);
            bw.WriteInt32(m_atomToCompiledAtomOffset_10);
            bw.WriteInt32(m_resultToRuntime_0);
            bw.WriteInt32(m_resultToRuntime_1);
            bw.WriteInt32(m_resultToRuntime_2);
            bw.WriteInt32(m_resultToRuntime_3);
            bw.WriteInt32(m_resultToRuntime_4);
            bw.WriteInt32(m_resultToRuntime_5);
            bw.WriteInt32(m_resultToRuntime_6);
            bw.WriteInt32(m_resultToRuntime_7);
            bw.WriteInt32(m_resultToRuntime_8);
            bw.WriteInt32(m_resultToRuntime_9);
            bw.WriteInt32(m_resultToRuntime_10);
            bw.WriteInt32(m_resultToRuntime_11);
            bw.WriteInt32(m_resultToRuntime_12);
            bw.WriteInt32(m_resultToRuntime_13);
            bw.WriteInt32(m_resultToRuntime_14);
            bw.WriteInt32(m_resultToRuntime_15);
            bw.WriteInt32(m_resultToRuntime_16);
            bw.WriteInt32(m_resultToRuntime_17);
            bw.WriteInt32(m_resultToRuntime_18);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
        }
    }
}