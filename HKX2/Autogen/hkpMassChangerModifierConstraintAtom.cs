using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMassChangerModifierConstraintAtom Signatire: 0xb6b28240 size: 80 flags: FLAGS_NONE

    // m_factorA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_factorB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpMassChangerModifierConstraintAtom : hkpModifierConstraintAtom
    {

        public Vector4 m_factorA;
        public Vector4 m_factorB;

        public override uint Signature => 0xb6b28240;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_factorA = br.ReadVector4();
            m_factorB = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_factorA);
            bw.WriteVector4(m_factorB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

