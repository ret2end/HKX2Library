using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbClipGenerator Signatire: 0x333b85b9 size: 272 flags: FLAGS_NONE

    // m_animationName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_triggers m_class: hkbClipTriggerArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_cropStartAmountLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_cropEndAmountLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_startTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_playbackSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_enforcedDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_userControlledTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    // m_animationBindingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_mode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 114 flags: FLAGS_NONE enum: PlaybackMode
    // m_flags m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 115 flags: FLAGS_NONE enum: 
    // m_animDatas m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_animationControl m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 136 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_originalTriggers m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_mapperData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 152 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_binding m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_mirroredAnimation m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_extractedMotion m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 176 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_echos m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 224 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 240 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 244 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_previousUserControlledTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 248 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_bufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 252 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_echoBufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 256 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_atEnd m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 260 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_ignoreStartTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 261 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_pingPongBackward m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 262 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbClipGenerator : hkbGenerator
    {
        public string m_animationName { set; get; } = "";
        public hkbClipTriggerArray? m_triggers { set; get; } = default;
        public float m_cropStartAmountLocalTime { set; get; } = default;
        public float m_cropEndAmountLocalTime { set; get; } = default;
        public float m_startTime { set; get; } = default;
        public float m_playbackSpeed { set; get; } = default;
        public float m_enforcedDuration { set; get; } = default;
        public float m_userControlledTimeFraction { set; get; } = default;
        public short m_animationBindingIndex { set; get; } = default;
        public sbyte m_mode { set; get; } = default;
        public sbyte m_flags { set; get; } = default;
        public IList<object> m_animDatas { set; get; } = new List<object>();
        private object? m_animationControl { set; get; } = default;
        private object? m_originalTriggers { set; get; } = default;
        private object? m_mapperData { set; get; } = default;
        private object? m_binding { set; get; } = default;
        private object? m_mirroredAnimation { set; get; } = default;
        private Matrix4x4 m_extractedMotion { set; get; } = default;
        public IList<object> m_echos { set; get; } = new List<object>();
        private float m_localTime { set; get; } = default;
        private float m_time { set; get; } = default;
        private float m_previousUserControlledTimeFraction { set; get; } = default;
        private int m_bufferSize { set; get; } = default;
        private int m_echoBufferSize { set; get; } = default;
        private bool m_atEnd { set; get; } = default;
        private bool m_ignoreStartTime { set; get; } = default;
        private bool m_pingPongBackward { set; get; } = default;

        public override uint Signature => 0x333b85b9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_animationName = des.ReadStringPointer(br);
            m_triggers = des.ReadClassPointer<hkbClipTriggerArray>(br);
            m_cropStartAmountLocalTime = br.ReadSingle();
            m_cropEndAmountLocalTime = br.ReadSingle();
            m_startTime = br.ReadSingle();
            m_playbackSpeed = br.ReadSingle();
            m_enforcedDuration = br.ReadSingle();
            m_userControlledTimeFraction = br.ReadSingle();
            m_animationBindingIndex = br.ReadInt16();
            m_mode = br.ReadSByte();
            m_flags = br.ReadSByte();
            br.Position += 4;
            des.ReadEmptyArray(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            m_extractedMotion = des.ReadQSTransform(br);
            des.ReadEmptyArray(br);
            m_localTime = br.ReadSingle();
            m_time = br.ReadSingle();
            m_previousUserControlledTimeFraction = br.ReadSingle();
            m_bufferSize = br.ReadInt32();
            m_echoBufferSize = br.ReadInt32();
            m_atEnd = br.ReadBoolean();
            m_ignoreStartTime = br.ReadBoolean();
            m_pingPongBackward = br.ReadBoolean();
            br.Position += 9;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_animationName);
            s.WriteClassPointer(bw, m_triggers);
            bw.WriteSingle(m_cropStartAmountLocalTime);
            bw.WriteSingle(m_cropEndAmountLocalTime);
            bw.WriteSingle(m_startTime);
            bw.WriteSingle(m_playbackSpeed);
            bw.WriteSingle(m_enforcedDuration);
            bw.WriteSingle(m_userControlledTimeFraction);
            bw.WriteInt16(m_animationBindingIndex);
            bw.WriteSByte(m_mode);
            bw.WriteSByte(m_flags);
            bw.Position += 4;
            s.WriteVoidArray(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteQSTransform(bw, m_extractedMotion);
            s.WriteVoidArray(bw);
            bw.WriteSingle(m_localTime);
            bw.WriteSingle(m_time);
            bw.WriteSingle(m_previousUserControlledTimeFraction);
            bw.WriteInt32(m_bufferSize);
            bw.WriteInt32(m_echoBufferSize);
            bw.WriteBoolean(m_atEnd);
            bw.WriteBoolean(m_ignoreStartTime);
            bw.WriteBoolean(m_pingPongBackward);
            bw.Position += 9;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_animationName = xd.ReadString(xe, nameof(m_animationName));
            m_triggers = xd.ReadClassPointer<hkbClipTriggerArray>(xe, nameof(m_triggers));
            m_cropStartAmountLocalTime = xd.ReadSingle(xe, nameof(m_cropStartAmountLocalTime));
            m_cropEndAmountLocalTime = xd.ReadSingle(xe, nameof(m_cropEndAmountLocalTime));
            m_startTime = xd.ReadSingle(xe, nameof(m_startTime));
            m_playbackSpeed = xd.ReadSingle(xe, nameof(m_playbackSpeed));
            m_enforcedDuration = xd.ReadSingle(xe, nameof(m_enforcedDuration));
            m_userControlledTimeFraction = xd.ReadSingle(xe, nameof(m_userControlledTimeFraction));
            m_animationBindingIndex = xd.ReadInt16(xe, nameof(m_animationBindingIndex));
            m_mode = xd.ReadFlag<PlaybackMode, sbyte>(xe, nameof(m_mode));
            m_flags = xd.ReadSByte(xe, nameof(m_flags));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_animationName), m_animationName);
            xs.WriteClassPointer(xe, nameof(m_triggers), m_triggers);
            xs.WriteFloat(xe, nameof(m_cropStartAmountLocalTime), m_cropStartAmountLocalTime);
            xs.WriteFloat(xe, nameof(m_cropEndAmountLocalTime), m_cropEndAmountLocalTime);
            xs.WriteFloat(xe, nameof(m_startTime), m_startTime);
            xs.WriteFloat(xe, nameof(m_playbackSpeed), m_playbackSpeed);
            xs.WriteFloat(xe, nameof(m_enforcedDuration), m_enforcedDuration);
            xs.WriteFloat(xe, nameof(m_userControlledTimeFraction), m_userControlledTimeFraction);
            xs.WriteNumber(xe, nameof(m_animationBindingIndex), m_animationBindingIndex);
            xs.WriteEnum<PlaybackMode, sbyte>(xe, nameof(m_mode), m_mode);
            xs.WriteNumber(xe, nameof(m_flags), m_flags);
            xs.WriteSerializeIgnored(xe, nameof(m_animDatas));
            xs.WriteSerializeIgnored(xe, nameof(m_animationControl));
            xs.WriteSerializeIgnored(xe, nameof(m_originalTriggers));
            xs.WriteSerializeIgnored(xe, nameof(m_mapperData));
            xs.WriteSerializeIgnored(xe, nameof(m_binding));
            xs.WriteSerializeIgnored(xe, nameof(m_mirroredAnimation));
            xs.WriteSerializeIgnored(xe, nameof(m_extractedMotion));
            xs.WriteSerializeIgnored(xe, nameof(m_echos));
            xs.WriteSerializeIgnored(xe, nameof(m_localTime));
            xs.WriteSerializeIgnored(xe, nameof(m_time));
            xs.WriteSerializeIgnored(xe, nameof(m_previousUserControlledTimeFraction));
            xs.WriteSerializeIgnored(xe, nameof(m_bufferSize));
            xs.WriteSerializeIgnored(xe, nameof(m_echoBufferSize));
            xs.WriteSerializeIgnored(xe, nameof(m_atEnd));
            xs.WriteSerializeIgnored(xe, nameof(m_ignoreStartTime));
            xs.WriteSerializeIgnored(xe, nameof(m_pingPongBackward));
        }
    }
}

