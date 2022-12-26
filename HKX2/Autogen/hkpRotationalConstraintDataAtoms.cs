using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRotationalConstraintDataAtoms Signatire: 0xa0c64586 size: 128 flags: FLAGS_NONE

    // m_rotations m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_ang m_class: hkpAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    
    public class hkpRotationalConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalRotationsConstraintAtom/*struct void*/ m_rotations;
        public hkpAngConstraintAtom/*struct void*/ m_ang;

        public uint Signature => 0xa0c64586;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des,br);
            m_ang = new hkpAngConstraintAtom();
            m_ang.Read(des,br);
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_rotations.Write(s, bw);
            m_ang.Write(s, bw);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

