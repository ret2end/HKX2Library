namespace HKX2
{
    public enum ConstraintPriority
    {
        PRIORITY_INVALID = 0,
        PRIORITY_PSI = 1,
        PRIORITY_SIMPLIFIED_TOI_UNUSED = 2,
        PRIORITY_TOI = 3,
        PRIORITY_TOI_HIGHER = 4,
        PRIORITY_TOI_FORCED = 5,
        NUM_PRIORITIES = 6
    }

    public enum InstanceType
    {
        TYPE_NORMAL = 0,
        TYPE_CHAIN = 1,
        TYPE_DISABLE_SPU = 2
    }

    public enum AddReferences
    {
        DO_NOT_ADD_REFERENCES = 0,
        DO_ADD_REFERENCES = 1
    }

    public enum CloningMode
    {
        CLONE_SHALLOW_IF_NOT_CONSTRAINED_TO_WORLD = 0,
        CLONE_DATAS_WITH_MOTORS = 1,
        CLONE_FORCE_SHALLOW = 2
    }

    public enum OnDestructionRemapInfo
    {
        ON_DESTRUCTION_REMAP = 0,
        ON_DESTRUCTION_REMOVE = 1,
        ON_DESTRUCTION_RESET_REMOVE = 2
    }

    public class hkpConstraintInstance : hkReferencedObject
    {
        public hkpModifierConstraintAtom m_constraintModifiers;

        public hkpConstraintData m_data;
        public OnDestructionRemapInfo m_destructionRemapInfo;
        public hkpEntity m_entities_0;
        public hkpEntity m_entities_1;
        public string m_name;
        public ConstraintPriority m_priority;
        public ulong m_userData;
        public bool m_wantRuntime;
        public override uint Signature => 0xDA4CE91E;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUSize(); // owner
            m_data = des.ReadClassPointer<hkpConstraintData>(br);
            m_constraintModifiers = des.ReadClassPointer<hkpModifierConstraintAtom>(br);
            m_entities_0 = des.ReadClassPointer<hkpEntity>(br);
            m_entities_1 = des.ReadClassPointer<hkpEntity>(br);
            m_priority = (ConstraintPriority) br.ReadByte();
            m_wantRuntime = br.ReadBoolean();
            m_destructionRemapInfo = (OnDestructionRemapInfo) br.ReadByte();
            br.ReadByte();
            new hkpConstraintInstanceSmallArraySerializeOverrideType().Read(des, br); // listeners
            m_name = des.ReadStringPointer(br);
            m_userData = br.ReadUSize();
            des.ReadEmptyPointer(br);
            br.ReadUInt32(); // uid

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUSize(0); // owner
            s.WriteClassPointer(bw, m_data);
            s.WriteClassPointer(bw, m_constraintModifiers);
            s.WriteClassPointer(bw, m_entities_0);
            s.WriteClassPointer(bw, m_entities_1);
            bw.WriteByte((byte) m_priority);
            bw.WriteBoolean(m_wantRuntime);
            bw.WriteByte((byte) m_destructionRemapInfo);
            bw.WriteByte(0);
            new hkpConstraintInstanceSmallArraySerializeOverrideType().Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUSize(m_userData);
            s.WriteVoidPointer(bw);
            bw.WriteUInt32(0); // uid

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}