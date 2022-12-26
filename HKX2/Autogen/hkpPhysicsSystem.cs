using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPhysicsSystem Signatire: 0xff724c17 size: 104 flags: FLAGS_NONE

    // m_rigidBodies m_class: hkpRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_constraints m_class: hkpConstraintInstance Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    // m_actions m_class: hkpAction Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags:  enum: 
    // m_phantoms m_class: hkpPhantom Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_active m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    
    public class hkpPhysicsSystem : hkReferencedObject
    {

        public List<hkpRigidBody> m_rigidBodies;
        public List<hkpConstraintInstance> m_constraints;
        public List<hkpAction> m_actions;
        public List<hkpPhantom> m_phantoms;
        public string m_name;
        public ulong m_userData;
        public bool m_active;

        public override uint Signature => 0xff724c17;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rigidBodies = des.ReadClassPointerArray<hkpRigidBody>(br);
            m_constraints = des.ReadClassPointerArray<hkpConstraintInstance>(br);
            m_actions = des.ReadClassPointerArray<hkpAction>(br);
            m_phantoms = des.ReadClassPointerArray<hkpPhantom>(br);
            m_name = des.ReadStringPointer(br);
            m_userData = br.ReadUInt64();
            m_active = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpRigidBody>(bw, m_rigidBodies);
            s.WriteClassPointerArray<hkpConstraintInstance>(bw, m_constraints);
            s.WriteClassPointerArray<hkpAction>(bw, m_actions);
            s.WriteClassPointerArray<hkpPhantom>(bw, m_phantoms);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt64(m_userData);
            bw.WriteBoolean(m_active);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

