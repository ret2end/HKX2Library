using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbClipGenerator Signatire: 0x333b85b9 size: 272 flags: FLAGS_NONE

    // m_animationName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_triggers m_class: hkbClipTriggerArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_cropStartAmountLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_cropEndAmountLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_startTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_playbackSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_enforcedDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_userControlledTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_animationBindingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_mode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 114 flags:  enum: PlaybackMode
    // m_flags m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 115 flags:  enum: 
    // m_animDatas m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_animationControl m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 136 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_originalTriggers m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_mapperData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 152 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_binding m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_mirroredAnimation m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_extractedMotion m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_echos m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 240 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 244 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_previousUserControlledTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 248 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 252 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_echoBufferSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 256 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_atEnd m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 260 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_ignoreStartTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 261 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pingPongBackward m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 262 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbClipGenerator : hkbGenerator
    {

        public string m_animationName;
        public hkbClipTriggerArray /*pointer struct*/ m_triggers;
        public float m_cropStartAmountLocalTime;
        public float m_cropEndAmountLocalTime;
        public float m_startTime;
        public float m_playbackSpeed;
        public float m_enforcedDuration;
        public float m_userControlledTimeFraction;
        public short m_animationBindingIndex;
        public sbyte m_mode;
        public sbyte m_flags;
        public List<ulong> m_animDatas;
        public dynamic /* POINTER VOID */ m_animationControl;
        public dynamic /* POINTER VOID */ m_originalTriggers;
        public dynamic /* POINTER VOID */ m_mapperData;
        public dynamic /* POINTER VOID */ m_binding;
        public dynamic /* POINTER VOID */ m_mirroredAnimation;
        public Matrix4x4 m_extractedMotion;
        public List<ulong> m_echos;
        public float m_localTime;
        public float m_time;
        public float m_previousUserControlledTimeFraction;
        public int m_bufferSize;
        public int m_echoBufferSize;
        public bool m_atEnd;
        public bool m_ignoreStartTime;
        public bool m_pingPongBackward;

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
            des.ReadEmptyArray(br); //m_animDatas
            des.ReadEmptyPointer(br);/* m_animationControl POINTER VOID */
            des.ReadEmptyPointer(br);/* m_originalTriggers POINTER VOID */
            des.ReadEmptyPointer(br);/* m_mapperData POINTER VOID */
            des.ReadEmptyPointer(br);/* m_binding POINTER VOID */
            des.ReadEmptyPointer(br);/* m_mirroredAnimation POINTER VOID */
            m_extractedMotion = des.ReadQSTransform(br);
            des.ReadEmptyArray(br); //m_echos
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
            s.WriteStringPointer(bw, m_animationName);
            s.WriteClassPointer(bw, m_triggers);
            bw.WriteSingle(m_cropStartAmountLocalTime);
            bw.WriteSingle(m_cropEndAmountLocalTime);
            bw.WriteSingle(m_startTime);
            bw.WriteSingle(m_playbackSpeed);
            bw.WriteSingle(m_enforcedDuration);
            bw.WriteSingle(m_userControlledTimeFraction);
            bw.WriteInt16(m_animationBindingIndex);
            s.WriteSByte(bw, m_mode);
            bw.WriteSByte(m_flags);
            bw.Position += 4;
            s.WriteVoidArray(bw); // m_animDatas
            s.WriteVoidPointer(bw);/* m_animationControl POINTER VOID */
            s.WriteVoidPointer(bw);/* m_originalTriggers POINTER VOID */
            s.WriteVoidPointer(bw);/* m_mapperData POINTER VOID */
            s.WriteVoidPointer(bw);/* m_binding POINTER VOID */
            s.WriteVoidPointer(bw);/* m_mirroredAnimation POINTER VOID */
            s.WriteQSTransform(bw, m_extractedMotion);
            s.WriteVoidArray(bw); // m_echos
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

