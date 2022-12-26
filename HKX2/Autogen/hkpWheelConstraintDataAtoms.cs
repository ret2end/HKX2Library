using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpWheelConstraintDataAtoms Signatire: 0x1188cbe1 size: 304 flags: FLAGS_NONE

    // m_suspensionBase m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_lin0Limit m_class: hkpLinLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_lin0Soft m_class: hkpLinSoftConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 156 flags:  enum: 
    // m_lin1 m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_lin2 m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 172 flags:  enum: 
    // m_steeringBase m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 288 flags:  enum: 
    
    public class hkpWheelConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_suspensionBase;
        public hkpLinLimitConstraintAtom/*struct void*/ m_lin0Limit;
        public hkpLinSoftConstraintAtom/*struct void*/ m_lin0Soft;
        public hkpLinConstraintAtom/*struct void*/ m_lin1;
        public hkpLinConstraintAtom/*struct void*/ m_lin2;
        public hkpSetLocalRotationsConstraintAtom/*struct void*/ m_steeringBase;
        public hkp2dAngConstraintAtom/*struct void*/ m_2dAng;

        public uint Signature => 0x1188cbe1;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_suspensionBase = new hkpSetLocalTransformsConstraintAtom();
            m_suspensionBase.Read(des,br);
            m_lin0Limit = new hkpLinLimitConstraintAtom();
            m_lin0Limit.Read(des,br);
            m_lin0Soft = new hkpLinSoftConstraintAtom();
            m_lin0Soft.Read(des,br);
            m_lin1 = new hkpLinConstraintAtom();
            m_lin1.Read(des,br);
            m_lin2 = new hkpLinConstraintAtom();
            m_lin2.Read(des,br);
            m_steeringBase = new hkpSetLocalRotationsConstraintAtom();
            m_steeringBase.Read(des,br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des,br);
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_suspensionBase.Write(s, bw);
            m_lin0Limit.Write(s, bw);
            m_lin0Soft.Write(s, bw);
            m_lin1.Write(s, bw);
            m_lin2.Write(s, bw);
            m_steeringBase.Write(s, bw);
            m_2dAng.Write(s, bw);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

