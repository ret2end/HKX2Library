using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLinConstraintAtom Signatire: 0x7b6b0210 size: 4 flags: FLAGS_NONE

    // m_axisIndex m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    
    public class hkpLinConstraintAtom : hkpConstraintAtom
    {

        public byte m_axisIndex;

        public override uint Signature => 0x7b6b0210;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_axisIndex = br.ReadByte();
            br.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_axisIndex);
            bw.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

