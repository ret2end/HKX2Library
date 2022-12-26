using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRagdollLimitsDataAtoms Signatire: 0x82b894c3 size: 176 flags: FLAGS_NONE

    // m_rotations m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_twistLimit m_class: hkpTwistLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_coneLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    // m_planesLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 152 flags:  enum: 
    
    public class hkpRagdollLimitsDataAtoms : IHavokObject
    {

        public hkpSetLocalRotationsConstraintAtom/*struct void*/ m_rotations;
        public hkpTwistLimitConstraintAtom/*struct void*/ m_twistLimit;
        public hkpConeLimitConstraintAtom/*struct void*/ m_coneLimit;
        public hkpConeLimitConstraintAtom/*struct void*/ m_planesLimit;

        public uint Signature => 0x82b894c3;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des,br);
            m_twistLimit = new hkpTwistLimitConstraintAtom();
            m_twistLimit.Read(des,br);
            m_coneLimit = new hkpConeLimitConstraintAtom();
            m_coneLimit.Read(des,br);
            m_planesLimit = new hkpConeLimitConstraintAtom();
            m_planesLimit.Read(des,br);
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_rotations.Write(s, bw);
            m_twistLimit.Write(s, bw);
            m_coneLimit.Write(s, bw);
            m_planesLimit.Write(s, bw);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

