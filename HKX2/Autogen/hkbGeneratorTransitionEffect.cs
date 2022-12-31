using System.Xml.Linq;

namespace HKX2
{
    // hkbGeneratorTransitionEffect Signatire: 0x5f771b12 size: 144 flags: FLAGS_NONE

    // m_transitionGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_blendInDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_blendOutDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_syncToGeneratorStartTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_fromGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_toGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_timeInTransition m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_effectiveBlendInDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 128 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_effectiveBlendOutDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_toGeneratorState m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 136 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_echoTransitionGenerator m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 137 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_echoToGenerator m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 138 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_justActivated m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 139 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_updateActiveNodes m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 140 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_stage m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 141 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbGeneratorTransitionEffect : hkbTransitionEffect
    {
        public hkbGenerator m_transitionGenerator;
        public float m_blendInDuration;
        public float m_blendOutDuration;
        public bool m_syncToGeneratorStartTime;
        public dynamic m_fromGenerator;
        public dynamic m_toGenerator;
        public float m_timeInTransition;
        public float m_duration;
        public float m_effectiveBlendInDuration;
        public float m_effectiveBlendOutDuration;
        public sbyte m_toGeneratorState;
        public bool m_echoTransitionGenerator;
        public bool m_echoToGenerator;
        public bool m_justActivated;
        public bool m_updateActiveNodes;
        public sbyte m_stage;

        public override uint Signature => 0x5f771b12;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transitionGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_blendInDuration = br.ReadSingle();
            m_blendOutDuration = br.ReadSingle();
            m_syncToGeneratorStartTime = br.ReadBoolean();
            br.Position += 7;
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            m_timeInTransition = br.ReadSingle();
            m_duration = br.ReadSingle();
            m_effectiveBlendInDuration = br.ReadSingle();
            m_effectiveBlendOutDuration = br.ReadSingle();
            m_toGeneratorState = br.ReadSByte();
            m_echoTransitionGenerator = br.ReadBoolean();
            m_echoToGenerator = br.ReadBoolean();
            m_justActivated = br.ReadBoolean();
            m_updateActiveNodes = br.ReadBoolean();
            m_stage = br.ReadSByte();
            br.Position += 2;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_transitionGenerator);
            bw.WriteSingle(m_blendInDuration);
            bw.WriteSingle(m_blendOutDuration);
            bw.WriteBoolean(m_syncToGeneratorStartTime);
            bw.Position += 7;
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            bw.WriteSingle(m_timeInTransition);
            bw.WriteSingle(m_duration);
            bw.WriteSingle(m_effectiveBlendInDuration);
            bw.WriteSingle(m_effectiveBlendOutDuration);
            s.WriteSByte(bw, m_toGeneratorState);
            bw.WriteBoolean(m_echoTransitionGenerator);
            bw.WriteBoolean(m_echoToGenerator);
            bw.WriteBoolean(m_justActivated);
            bw.WriteBoolean(m_updateActiveNodes);
            s.WriteSByte(bw, m_stage);
            bw.Position += 2;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_transitionGenerator), m_transitionGenerator);
            xs.WriteFloat(xe, nameof(m_blendInDuration), m_blendInDuration);
            xs.WriteFloat(xe, nameof(m_blendOutDuration), m_blendOutDuration);
            xs.WriteBoolean(xe, nameof(m_syncToGeneratorStartTime), m_syncToGeneratorStartTime);
            xs.WriteSerializeIgnored(xe, nameof(m_fromGenerator));
            xs.WriteSerializeIgnored(xe, nameof(m_toGenerator));
            xs.WriteSerializeIgnored(xe, nameof(m_timeInTransition));
            xs.WriteSerializeIgnored(xe, nameof(m_duration));
            xs.WriteSerializeIgnored(xe, nameof(m_effectiveBlendInDuration));
            xs.WriteSerializeIgnored(xe, nameof(m_effectiveBlendOutDuration));
            xs.WriteSerializeIgnored(xe, nameof(m_toGeneratorState));
            xs.WriteSerializeIgnored(xe, nameof(m_echoTransitionGenerator));
            xs.WriteSerializeIgnored(xe, nameof(m_echoToGenerator));
            xs.WriteSerializeIgnored(xe, nameof(m_justActivated));
            xs.WriteSerializeIgnored(xe, nameof(m_updateActiveNodes));
            xs.WriteSerializeIgnored(xe, nameof(m_stage));
        }
    }
}

