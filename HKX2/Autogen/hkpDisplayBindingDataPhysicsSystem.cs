using System.Collections.Generic;

namespace HKX2
{
    public class hkpDisplayBindingDataPhysicsSystem : hkReferencedObject
    {
        public List<hkpDisplayBindingDataRigidBody> m_bindings;
        public hkpPhysicsSystem m_system;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bindings = des.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(br);
            m_system = des.ReadClassPointer<hkpPhysicsSystem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_bindings);
            s.WriteClassPointer(bw, m_system);
        }
    }
}