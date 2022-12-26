using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbGetWorldFromModelModifier Signatire: 0x873fc6f7 size: 112 flags: FLAGS_NONE

    // m_translationOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_rotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    
    public class hkbGetWorldFromModelModifier : hkbModifier
    {

        public Vector4 m_translationOut;
        public Quaternion m_rotationOut;

        public override uint Signature => 0x873fc6f7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_translationOut = br.ReadVector4();
            m_rotationOut = des.ReadQuaternion(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_translationOut);
            s.WriteQuaternion(bw, m_rotationOut);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

