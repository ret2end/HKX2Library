using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSetLocalTranslationsConstraintAtom Signatire: 0x5cbfcf4a size: 48 flags: FLAGS_NONE

    // m_translationA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_translationB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpSetLocalTranslationsConstraintAtom : hkpConstraintAtom
    {

        public Vector4 m_translationA;
        public Vector4 m_translationB;

        public override uint Signature => 0x5cbfcf4a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 14;
            m_translationA = br.ReadVector4();
            m_translationB = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 14;
            bw.WriteVector4(m_translationA);
            bw.WriteVector4(m_translationB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

