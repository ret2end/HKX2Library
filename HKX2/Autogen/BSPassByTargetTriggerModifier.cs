using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSPassByTargetTriggerModifier Signatire: 0x703d7b66 size: 160 flags: FLAGS_NONE

    // m_targetPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_radius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_movementDirection m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_triggerEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_targetPassed m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSPassByTargetTriggerModifier : hkbModifier
    {

        public Vector4 m_targetPosition;
        public float m_radius;
        public Vector4 m_movementDirection;
        public hkbEventProperty/*struct void*/ m_triggerEvent;
        public bool m_targetPassed;

        public override uint Signature => 0x703d7b66;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_targetPosition = br.ReadVector4();
            m_radius = br.ReadSingle();
            br.Position += 12;
            m_movementDirection = br.ReadVector4();
            m_triggerEvent = new hkbEventProperty();
            m_triggerEvent.Read(des,br);
            m_targetPassed = br.ReadBoolean();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_targetPosition);
            bw.WriteSingle(m_radius);
            bw.Position += 12;
            bw.WriteVector4(m_movementDirection);
            m_triggerEvent.Write(s, bw);
            bw.WriteBoolean(m_targetPassed);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

