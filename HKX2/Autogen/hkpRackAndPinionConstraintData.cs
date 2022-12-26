using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRackAndPinionConstraintData Signatire: 0xd180ebe0 size: 192 flags: FLAGS_NONE

    // m_atoms m_class: hkpRackAndPinionConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpRackAndPinionConstraintData : hkpConstraintData
    {

        public hkpRackAndPinionConstraintDataAtoms/*struct void*/ m_atoms;

        public override uint Signature => 0xd180ebe0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpRackAndPinionConstraintDataAtoms();
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

