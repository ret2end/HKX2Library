using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSetWorldFromModelModifier Signatire: 0xafcfa211 size: 128 flags: FLAGS_NONE

    // m_translation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_setTranslation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_setRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 113 flags:  enum: 
    
    public class hkbSetWorldFromModelModifier : hkbModifier
    {

        public Vector4 m_translation;
        public Quaternion m_rotation;
        public bool m_setTranslation;
        public bool m_setRotation;

        public override uint Signature => 0xafcfa211;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_translation = br.ReadVector4();
            m_rotation = des.ReadQuaternion(br);
            m_setTranslation = br.ReadBoolean();
            m_setRotation = br.ReadBoolean();
            br.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_translation);
            s.WriteQuaternion(bw, m_rotation);
            bw.WriteBoolean(m_setTranslation);
            bw.WriteBoolean(m_setRotation);
            bw.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

