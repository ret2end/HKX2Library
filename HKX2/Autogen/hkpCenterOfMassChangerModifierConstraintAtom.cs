using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCenterOfMassChangerModifierConstraintAtom Signatire: 0x1d7dbdd2 size: 80 flags: FLAGS_NONE

    // m_displacementA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_displacementB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpCenterOfMassChangerModifierConstraintAtom : hkpModifierConstraintAtom
    {

        public Vector4 m_displacementA;
        public Vector4 m_displacementB;

        public override uint Signature => 0x1d7dbdd2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_displacementA = br.ReadVector4();
            m_displacementB = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_displacementA);
            bw.WriteVector4(m_displacementB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

