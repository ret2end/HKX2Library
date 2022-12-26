using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpHingeLimitsDataAtoms Signatire: 0x555876ff size: 144 flags: FLAGS_NONE

    // m_rotations m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_angLimit m_class: hkpAngLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    
    public class hkpHingeLimitsDataAtoms : IHavokObject
    {

        public hkpSetLocalRotationsConstraintAtom/*struct void*/ m_rotations;
        public hkpAngLimitConstraintAtom/*struct void*/ m_angLimit;
        public hkp2dAngConstraintAtom/*struct void*/ m_2dAng;

        public uint Signature => 0x555876ff;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des,br);
            m_angLimit = new hkpAngLimitConstraintAtom();
            m_angLimit.Read(des,br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des,br);
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_rotations.Write(s, bw);
            m_angLimit.Write(s, bw);
            m_2dAng.Write(s, bw);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

