using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTransformVectorModifierInternalState Signatire: 0x5ca91c99 size: 32 flags: FLAGS_NONE

    // m_vectorOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbTransformVectorModifierInternalState : hkReferencedObject
    {

        public Vector4 m_vectorOut;

        public override uint Signature => 0x5ca91c99;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_vectorOut = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_vectorOut);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

