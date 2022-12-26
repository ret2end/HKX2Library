using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPrismaticConstraintDataAtoms Signatire: 0x7f516137 size: 208 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_motor m_class: hkpLinMotorConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_friction m_class: hkpLinFrictionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_ang m_class: hkpAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_lin0 m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 180 flags:  enum: 
    // m_lin1 m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_linLimit m_class: hkpLinLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 188 flags:  enum: 
    
    public class hkpPrismaticConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpLinMotorConstraintAtom/*struct void*/ m_motor;
        public hkpLinFrictionConstraintAtom/*struct void*/ m_friction;
        public hkpAngConstraintAtom/*struct void*/ m_ang;
        public hkpLinConstraintAtom/*struct void*/ m_lin0;
        public hkpLinConstraintAtom/*struct void*/ m_lin1;
        public hkpLinLimitConstraintAtom/*struct void*/ m_linLimit;

        public uint Signature => 0x7f516137;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_motor = new hkpLinMotorConstraintAtom();
            m_motor.Read(des,br);
            m_friction = new hkpLinFrictionConstraintAtom();
            m_friction.Read(des,br);
            m_ang = new hkpAngConstraintAtom();
            m_ang.Read(des,br);
            m_lin0 = new hkpLinConstraintAtom();
            m_lin0.Read(des,br);
            m_lin1 = new hkpLinConstraintAtom();
            m_lin1.Read(des,br);
            m_linLimit = new hkpLinLimitConstraintAtom();
            m_linLimit.Read(des,br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transforms.Write(s, bw);
            m_motor.Write(s, bw);
            m_friction.Write(s, bw);
            m_ang.Write(s, bw);
            m_lin0.Write(s, bw);
            m_lin1.Write(s, bw);
            m_linLimit.Write(s, bw);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

