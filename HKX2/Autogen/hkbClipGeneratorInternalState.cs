using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbClipGeneratorInternalState Signatire: 0x26ce5bf3 size: 112 flags: FLAGS_NONE

    // m_extractedMotion m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_echos m_class: hkbClipGeneratorEcho Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_previousUserControlledTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_bufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_echoBufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_atEnd m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_ignoreStartTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 101 flags: FLAGS_NONE enum: 
    // m_pingPongBackward m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 102 flags: FLAGS_NONE enum: 
    public partial class hkbClipGeneratorInternalState : hkReferencedObject
    {
        public Matrix4x4 m_extractedMotion { set; get; } = default;
        public IList<hkbClipGeneratorEcho> m_echos { set; get; } = new List<hkbClipGeneratorEcho>();
        public float m_localTime { set; get; } = default;
        public float m_time { set; get; } = default;
        public float m_previousUserControlledTimeFraction { set; get; } = default;
        public int m_bufferSize { set; get; } = default;
        public int m_echoBufferSize { set; get; } = default;
        public bool m_atEnd { set; get; } = default;
        public bool m_ignoreStartTime { set; get; } = default;
        public bool m_pingPongBackward { set; get; } = default;

        public override uint Signature => 0x26ce5bf3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_extractedMotion = des.ReadQSTransform(br);
            m_echos = des.ReadClassArray<hkbClipGeneratorEcho>(br);
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
            s.WriteQSTransform(bw, m_extractedMotion);
            s.WriteClassArray(bw, m_echos);
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
            m_extractedMotion = xd.ReadQSTransform(xe, nameof(m_extractedMotion));
            m_echos = xd.ReadClassArray<hkbClipGeneratorEcho>(xe, nameof(m_echos));
            m_localTime = xd.ReadSingle(xe, nameof(m_localTime));
            m_time = xd.ReadSingle(xe, nameof(m_time));
            m_previousUserControlledTimeFraction = xd.ReadSingle(xe, nameof(m_previousUserControlledTimeFraction));
            m_bufferSize = xd.ReadInt32(xe, nameof(m_bufferSize));
            m_echoBufferSize = xd.ReadInt32(xe, nameof(m_echoBufferSize));
            m_atEnd = xd.ReadBoolean(xe, nameof(m_atEnd));
            m_ignoreStartTime = xd.ReadBoolean(xe, nameof(m_ignoreStartTime));
            m_pingPongBackward = xd.ReadBoolean(xe, nameof(m_pingPongBackward));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteQSTransform(xe, nameof(m_extractedMotion), m_extractedMotion);
            xs.WriteClassArray<hkbClipGeneratorEcho>(xe, nameof(m_echos), m_echos);
            xs.WriteFloat(xe, nameof(m_localTime), m_localTime);
            xs.WriteFloat(xe, nameof(m_time), m_time);
            xs.WriteFloat(xe, nameof(m_previousUserControlledTimeFraction), m_previousUserControlledTimeFraction);
            xs.WriteNumber(xe, nameof(m_bufferSize), m_bufferSize);
            xs.WriteNumber(xe, nameof(m_echoBufferSize), m_echoBufferSize);
            xs.WriteBoolean(xe, nameof(m_atEnd), m_atEnd);
            xs.WriteBoolean(xe, nameof(m_ignoreStartTime), m_ignoreStartTime);
            xs.WriteBoolean(xe, nameof(m_pingPongBackward), m_pingPongBackward);
        }
    }
}

