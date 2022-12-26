using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpStiffSpringConstraintAtom Signatire: 0x6c128096 size: 8 flags: FLAGS_NONE

    // m_length m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkpStiffSpringConstraintAtom : hkpConstraintAtom
    {

        public float m_length;

        public override uint Signature => 0x6c128096;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 2;
            m_length = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 2;
            bw.WriteSingle(m_length);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

