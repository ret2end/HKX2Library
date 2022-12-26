using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSDistTriggerModifier Signatire: 0xb34d2bbd size: 128 flags: FLAGS_NONE

    // m_targetPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_distance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_distanceTrigger m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_triggerEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    
    public class BSDistTriggerModifier : hkbModifier
    {

        public Vector4 m_targetPosition;
        public float m_distance;
        public float m_distanceTrigger;
        public hkbEventProperty/*struct void*/ m_triggerEvent;

        public override uint Signature => 0xb34d2bbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_targetPosition = br.ReadVector4();
            m_distance = br.ReadSingle();
            m_distanceTrigger = br.ReadSingle();
            m_triggerEvent = new hkbEventProperty();
            m_triggerEvent.Read(des,br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_targetPosition);
            bw.WriteSingle(m_distance);
            bw.WriteSingle(m_distanceTrigger);
            m_triggerEvent.Write(s, bw);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

