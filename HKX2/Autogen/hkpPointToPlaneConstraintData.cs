using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPointToPlaneConstraintData Signatire: 0x65c56e17 size: 192 flags: FLAGS_NONE

    // m_atoms m_class: hkpPointToPlaneConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpPointToPlaneConstraintData : hkpConstraintData
    {

        public hkpPointToPlaneConstraintDataAtoms/*struct void*/ m_atoms;

        public override uint Signature => 0x65c56e17;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpPointToPlaneConstraintDataAtoms();
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

