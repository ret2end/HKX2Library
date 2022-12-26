using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDisplayBindingData Signatire: 0xdc46c906 size: 48 flags: FLAGS_NONE

    // m_rigidBodyBindings m_class: hkpDisplayBindingDataRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_physicsSystemBindings m_class: hkpDisplayBindingDataPhysicsSystem Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpDisplayBindingData : hkReferencedObject
    {

        public List<hkpDisplayBindingDataRigidBody> m_rigidBodyBindings;
        public List<hkpDisplayBindingDataPhysicsSystem> m_physicsSystemBindings;

        public override uint Signature => 0xdc46c906;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rigidBodyBindings = des.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(br);
            m_physicsSystemBindings = des.ReadClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpDisplayBindingDataRigidBody>(bw, m_rigidBodyBindings);
            s.WriteClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(bw, m_physicsSystemBindings);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

