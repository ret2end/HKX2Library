using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpOverwritePivotConstraintAtom Signatire: 0x1f11b467 size: 4 flags: FLAGS_NONE

    // m_copyToPivotBFromPivotA m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    
    public class hkpOverwritePivotConstraintAtom : hkpConstraintAtom
    {

        public byte m_copyToPivotBFromPivotA;

        public override uint Signature => 0x1f11b467;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_copyToPivotBFromPivotA = br.ReadByte();
            br.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_copyToPivotBFromPivotA);
            bw.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

