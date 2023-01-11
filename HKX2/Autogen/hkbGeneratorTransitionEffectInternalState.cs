using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbGeneratorTransitionEffectInternalState Signatire: 0xd6692b5d size: 40 flags: FLAGS_NONE

    // m_timeInTransition m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_effectiveBlendInDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_effectiveBlendOutDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_toGeneratorState m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: ToGeneratorState
    // m_echoTransitionGenerator m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 33 flags: FLAGS_NONE enum: 
    // m_echoToGenerator m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 34 flags: FLAGS_NONE enum: 
    // m_justActivated m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 35 flags: FLAGS_NONE enum: 
    // m_updateActiveNodes m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_stage m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 37 flags: FLAGS_NONE enum: Stage
    public partial class hkbGeneratorTransitionEffectInternalState : hkReferencedObject
    {
        public float m_timeInTransition { set; get; } = default;
        public float m_duration { set; get; } = default;
        public float m_effectiveBlendInDuration { set; get; } = default;
        public float m_effectiveBlendOutDuration { set; get; } = default;
        public sbyte m_toGeneratorState { set; get; } = default;
        public bool m_echoTransitionGenerator { set; get; } = default;
        public bool m_echoToGenerator { set; get; } = default;
        public bool m_justActivated { set; get; } = default;
        public bool m_updateActiveNodes { set; get; } = default;
        public sbyte m_stage { set; get; } = default;

        public override uint Signature => 0xd6692b5d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
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
            bw.WriteSingle(m_timeInTransition);
            bw.WriteSingle(m_duration);
            bw.WriteSingle(m_effectiveBlendInDuration);
            bw.WriteSingle(m_effectiveBlendOutDuration);
            bw.WriteSByte(m_toGeneratorState);
            bw.WriteBoolean(m_echoTransitionGenerator);
            bw.WriteBoolean(m_echoToGenerator);
            bw.WriteBoolean(m_justActivated);
            bw.WriteBoolean(m_updateActiveNodes);
            bw.WriteSByte(m_stage);
            bw.Position += 2;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_timeInTransition = xd.ReadSingle(xe, nameof(m_timeInTransition));
            m_duration = xd.ReadSingle(xe, nameof(m_duration));
            m_effectiveBlendInDuration = xd.ReadSingle(xe, nameof(m_effectiveBlendInDuration));
            m_effectiveBlendOutDuration = xd.ReadSingle(xe, nameof(m_effectiveBlendOutDuration));
            m_toGeneratorState = xd.ReadFlag<ToGeneratorState, sbyte>(xe, nameof(m_toGeneratorState));
            m_echoTransitionGenerator = xd.ReadBoolean(xe, nameof(m_echoTransitionGenerator));
            m_echoToGenerator = xd.ReadBoolean(xe, nameof(m_echoToGenerator));
            m_justActivated = xd.ReadBoolean(xe, nameof(m_justActivated));
            m_updateActiveNodes = xd.ReadBoolean(xe, nameof(m_updateActiveNodes));
            m_stage = xd.ReadFlag<Stage, sbyte>(xe, nameof(m_stage));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_timeInTransition), m_timeInTransition);
            xs.WriteFloat(xe, nameof(m_duration), m_duration);
            xs.WriteFloat(xe, nameof(m_effectiveBlendInDuration), m_effectiveBlendInDuration);
            xs.WriteFloat(xe, nameof(m_effectiveBlendOutDuration), m_effectiveBlendOutDuration);
            xs.WriteEnum<ToGeneratorState, sbyte>(xe, nameof(m_toGeneratorState), m_toGeneratorState);
            xs.WriteBoolean(xe, nameof(m_echoTransitionGenerator), m_echoTransitionGenerator);
            xs.WriteBoolean(xe, nameof(m_echoToGenerator), m_echoToGenerator);
            xs.WriteBoolean(xe, nameof(m_justActivated), m_justActivated);
            xs.WriteBoolean(xe, nameof(m_updateActiveNodes), m_updateActiveNodes);
            xs.WriteEnum<Stage, sbyte>(xe, nameof(m_stage), m_stage);
        }
    }
}

