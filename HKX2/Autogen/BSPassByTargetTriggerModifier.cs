using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSPassByTargetTriggerModifier Signatire: 0x703d7b66 size: 160 flags: FLAGS_NONE

    // m_targetPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_radius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_movementDirection m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_triggerEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_targetPassed m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSPassByTargetTriggerModifier : hkbModifier
    {
        public Vector4 m_targetPosition { set; get; } = default;
        public float m_radius { set; get; } = default;
        public Vector4 m_movementDirection { set; get; } = default;
        public hkbEventProperty m_triggerEvent { set; get; } = new();
        private bool m_targetPassed { set; get; } = default;

        public override uint Signature => 0x703d7b66;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_targetPosition = br.ReadVector4();
            m_radius = br.ReadSingle();
            br.Position += 12;
            m_movementDirection = br.ReadVector4();
            m_triggerEvent.Read(des, br);
            m_targetPassed = br.ReadBoolean();
            br.Position += 15;
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_targetPosition = xd.ReadVector4(xe, nameof(m_targetPosition));
            m_radius = xd.ReadSingle(xe, nameof(m_radius));
            m_movementDirection = xd.ReadVector4(xe, nameof(m_movementDirection));
            m_triggerEvent = xd.ReadClass<hkbEventProperty>(xe, nameof(m_triggerEvent));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_targetPosition), m_targetPosition);
            xs.WriteFloat(xe, nameof(m_radius), m_radius);
            xs.WriteVector4(xe, nameof(m_movementDirection), m_movementDirection);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_triggerEvent), m_triggerEvent);
            xs.WriteSerializeIgnored(xe, nameof(m_targetPassed));
        }
    }
}

