using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDisplayBindingDataPhysicsSystem Signatire: 0xc8ae86a7 size: 40 flags: FLAGS_NONE

    // m_bindings m_class: hkpDisplayBindingDataRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_system m_class: hkpPhysicsSystem Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpDisplayBindingDataPhysicsSystem : hkReferencedObject
    {

        public List<hkpDisplayBindingDataRigidBody> m_bindings;
        public hkpPhysicsSystem /*pointer struct*/ m_system;

        public override uint Signature => 0xc8ae86a7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_bindings = des.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(br);
            m_system = des.ReadClassPointer<hkpPhysicsSystem>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpDisplayBindingDataRigidBody>(bw, m_bindings);
            s.WriteClassPointer(bw, m_system);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

