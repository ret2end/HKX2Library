using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaRagdollInstance Signatire: 0x154948e8 size: 72 flags: FLAGS_NONE

    // m_rigidBodies m_class: hkpRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_constraints m_class: hkpConstraintInstance Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    // m_boneToRigidBodyMap m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 48 flags:  enum: 
    // m_skeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkaRagdollInstance : hkReferencedObject
    {

        public List<hkpRigidBody> m_rigidBodies;
        public List<hkpConstraintInstance> m_constraints;
        public List<int> m_boneToRigidBodyMap;
        public hkaSkeleton /*pointer struct*/ m_skeleton;

        public override uint Signature => 0x154948e8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rigidBodies = des.ReadClassPointerArray<hkpRigidBody>(br);
            m_constraints = des.ReadClassPointerArray<hkpConstraintInstance>(br);
            m_boneToRigidBodyMap = des.ReadInt32Array(br);
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpRigidBody>(bw, m_rigidBodies);
            s.WriteClassPointerArray<hkpConstraintInstance>(bw, m_constraints);
            s.WriteInt32Array(bw, m_boneToRigidBodyMap);
            s.WriteClassPointer(bw, m_skeleton);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

