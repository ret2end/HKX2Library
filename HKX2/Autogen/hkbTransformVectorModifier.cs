using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTransformVectorModifier Signatire: 0xf93e0e24 size: 160 flags: FLAGS_NONE

    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_translation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_vectorIn m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_vectorOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_rotateOnly m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_inverse m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 145 flags:  enum: 
    // m_computeOnActivate m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 146 flags:  enum: 
    // m_computeOnModify m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 147 flags:  enum: 
    
    public class hkbTransformVectorModifier : hkbModifier
    {

        public Quaternion m_rotation;
        public Vector4 m_translation;
        public Vector4 m_vectorIn;
        public Vector4 m_vectorOut;
        public bool m_rotateOnly;
        public bool m_inverse;
        public bool m_computeOnActivate;
        public bool m_computeOnModify;

        public override uint Signature => 0xf93e0e24;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rotation = des.ReadQuaternion(br);
            m_translation = br.ReadVector4();
            m_vectorIn = br.ReadVector4();
            m_vectorOut = br.ReadVector4();
            m_rotateOnly = br.ReadBoolean();
            m_inverse = br.ReadBoolean();
            m_computeOnActivate = br.ReadBoolean();
            m_computeOnModify = br.ReadBoolean();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotation);
            bw.WriteVector4(m_translation);
            bw.WriteVector4(m_vectorIn);
            bw.WriteVector4(m_vectorOut);
            bw.WriteBoolean(m_rotateOnly);
            bw.WriteBoolean(m_inverse);
            bw.WriteBoolean(m_computeOnActivate);
            bw.WriteBoolean(m_computeOnModify);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

