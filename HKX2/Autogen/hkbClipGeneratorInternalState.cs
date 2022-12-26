using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbClipGeneratorInternalState Signatire: 0x26ce5bf3 size: 112 flags: FLAGS_NONE

    // m_extractedMotion m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_echos m_class: hkbClipGeneratorEcho Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 64 flags:  enum: 
    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_previousUserControlledTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_bufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_echoBufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_atEnd m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_ignoreStartTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 101 flags:  enum: 
    // m_pingPongBackward m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 102 flags:  enum: 
    
    public class hkbClipGeneratorInternalState : hkReferencedObject
    {

        public Matrix4x4 m_extractedMotion;
        public List<hkbClipGeneratorEcho> m_echos;
        public float m_localTime;
        public float m_time;
        public float m_previousUserControlledTimeFraction;
        public int m_bufferSize;
        public int m_echoBufferSize;
        public bool m_atEnd;
        public bool m_ignoreStartTime;
        public bool m_pingPongBackward;

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

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQSTransform(bw, m_extractedMotion);
            s.WriteClassArray<hkbClipGeneratorEcho>(bw, m_echos);
            bw.WriteSingle(m_localTime);
            bw.WriteSingle(m_time);
            bw.WriteSingle(m_previousUserControlledTimeFraction);
            bw.WriteInt32(m_bufferSize);
            bw.WriteInt32(m_echoBufferSize);
            bw.WriteBoolean(m_atEnd);
            bw.WriteBoolean(m_ignoreStartTime);
            bw.WriteBoolean(m_pingPongBackward);
            bw.Position += 9;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

