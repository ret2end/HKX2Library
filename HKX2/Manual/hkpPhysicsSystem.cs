using System.Collections.Generic;

namespace HKX2
{
    public enum CloneConstraintMode
    {
        CLONE_SHALLOW_IF_NOT_CONSTRAINED_TO_WORLD = 0,
        CLONE_DEEP_WITH_MOTORS = 1,
        CLONE_FORCE_SHALLOW = 2,
        CLONE_DEFAULT = 0
    }

    public class hkpPhysicsSystem : hkReferencedObject
    {
        public List<hkpAction> m_actions;
        public bool m_active;
        public List<hkpConstraintInstance> m_constraints;
        public string m_name;
        public List<hkpPhantom> m_phantoms;

        public List<hkpRigidBody> m_rigidBodies;
        public ulong m_userData;
        public override uint Signature => 0xB3CC6E64;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rigidBodies = des.ReadClassPointerArray<hkpRigidBody>(br);
            m_constraints = des.ReadClassPointerArray<hkpConstraintInstance>(br);
            m_actions = des.ReadClassPointerArray<hkpAction>(br);
            m_phantoms = des.ReadClassPointerArray<hkpPhantom>(br);
            m_name = des.ReadStringPointer(br);
            m_userData = br.ReadUSize();
            m_active = br.ReadBoolean();
            br.Pad(16);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_rigidBodies);
            s.WriteClassPointerArray(bw, m_constraints);
            s.WriteClassPointerArray(bw, m_actions);
            s.WriteClassPointerArray(bw, m_phantoms);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUSize(m_userData);
            bw.WriteBoolean(m_active);
            bw.Pad(16);
        }
    }
}