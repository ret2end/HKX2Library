using System.Collections.Generic;

namespace HKX2
{
    public class hkpDisplayBindingData : hkReferencedObject
    {
        public List<hkpDisplayBindingDataPhysicsSystem> m_physicsSystemBindings;

        public List<hkpDisplayBindingDataRigidBody> m_rigidBodyBindings;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rigidBodyBindings = des.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(br);
            m_physicsSystemBindings = des.ReadClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_rigidBodyBindings);
            s.WriteClassPointerArray(bw, m_physicsSystemBindings);
        }
    }
}