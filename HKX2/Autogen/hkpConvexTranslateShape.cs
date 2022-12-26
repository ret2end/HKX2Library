using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexTranslateShape Signatire: 0x5ba0a5f7 size: 80 flags: FLAGS_NONE

    // m_translation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpConvexTranslateShape : hkpConvexTransformShapeBase
    {

        public Vector4 m_translation;

        public override uint Signature => 0x5ba0a5f7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_translation = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_translation);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

