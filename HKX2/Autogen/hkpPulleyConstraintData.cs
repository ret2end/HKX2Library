using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPulleyConstraintData Signatire: 0x972058ed size: 144 flags: FLAGS_NONE

    // m_atoms m_class: hkpPulleyConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpPulleyConstraintData : hkpConstraintData
    {

        public hkpPulleyConstraintDataAtoms/*struct void*/ m_atoms;

        public override uint Signature => 0x972058ed;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpPulleyConstraintDataAtoms();
            m_atoms.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            m_atoms.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

