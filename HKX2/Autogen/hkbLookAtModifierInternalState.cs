using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbLookAtModifierInternalState Signatire: 0xa14caba6 size: 48 flags: FLAGS_NONE

    // m_lookAtLastTargetWS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_lookAtWeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_isTargetInsideLimitCone m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    
    public class hkbLookAtModifierInternalState : hkReferencedObject
    {

        public Vector4 m_lookAtLastTargetWS;
        public float m_lookAtWeight;
        public bool m_isTargetInsideLimitCone;

        public override uint Signature => 0xa14caba6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_lookAtLastTargetWS = br.ReadVector4();
            m_lookAtWeight = br.ReadSingle();
            m_isTargetInsideLimitCone = br.ReadBoolean();
            br.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_lookAtLastTargetWS);
            bw.WriteSingle(m_lookAtWeight);
            bw.WriteBoolean(m_isTargetInsideLimitCone);
            bw.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

