using System.Xml.Linq;

namespace HKX2
{
    // BSCyclicBlendTransitionGenerator Signatire: 0x5119eb06 size: 176 flags: FLAGS_NONE

    // m_pBlenderGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_EventToFreezeBlendValue m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_EventToCrossBlend m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_fBlendParameter m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    // m_fTransitionDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags: FLAGS_NONE enum: 
    // m_eBlendCurve m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 128 flags: FLAGS_NONE enum: BlendCurve
    // m_pTransitionBlenderGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|ALIGN_16|FLAGS_NONE enum: 
    // m_pTransitionEffect m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|ALIGN_16|FLAGS_NONE enum: 
    // m_currentMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 168 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSCyclicBlendTransitionGenerator : hkbGenerator
    {
        public hkbGenerator m_pBlenderGenerator;
        public hkbEventProperty m_EventToFreezeBlendValue;
        public hkbEventProperty m_EventToCrossBlend;
        public float m_fBlendParameter;
        public float m_fTransitionDuration;
        public sbyte m_eBlendCurve;
        public dynamic m_pTransitionBlenderGenerator;
        public dynamic m_pTransitionEffect;
        public sbyte m_currentMode;

        public override uint Signature => 0x5119eb06;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_pBlenderGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_EventToFreezeBlendValue = new hkbEventProperty();
            m_EventToFreezeBlendValue.Read(des, br);
            m_EventToCrossBlend = new hkbEventProperty();
            m_EventToCrossBlend.Read(des, br);
            m_fBlendParameter = br.ReadSingle();
            m_fTransitionDuration = br.ReadSingle();
            m_eBlendCurve = br.ReadSByte();
            br.Position += 15;
            des.ReadEmptyPointer(br);
            br.Position += 8;
            des.ReadEmptyPointer(br);
            m_currentMode = br.ReadSByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pBlenderGenerator);
            m_EventToFreezeBlendValue.Write(s, bw);
            m_EventToCrossBlend.Write(s, bw);
            bw.WriteSingle(m_fBlendParameter);
            bw.WriteSingle(m_fTransitionDuration);
            s.WriteSByte(bw, m_eBlendCurve);
            bw.Position += 15;
            s.WriteVoidPointer(bw);
            bw.Position += 8;
            s.WriteVoidPointer(bw);
            s.WriteSByte(bw, m_currentMode);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_pBlenderGenerator), m_pBlenderGenerator);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_EventToFreezeBlendValue), m_EventToFreezeBlendValue);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_EventToCrossBlend), m_EventToCrossBlend);
            xs.WriteFloat(xe, nameof(m_fBlendParameter), m_fBlendParameter);
            xs.WriteFloat(xe, nameof(m_fTransitionDuration), m_fTransitionDuration);
            xs.WriteEnum<BlendCurve, sbyte>(xe, nameof(m_eBlendCurve), m_eBlendCurve);
            xs.WriteSerializeIgnored(xe, nameof(m_pTransitionBlenderGenerator));
            xs.WriteSerializeIgnored(xe, nameof(m_pTransitionEffect));
            xs.WriteSerializeIgnored(xe, nameof(m_currentMode));
        }
    }
}

