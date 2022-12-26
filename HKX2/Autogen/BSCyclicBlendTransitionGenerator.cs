using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSCyclicBlendTransitionGenerator Signatire: 0x5119eb06 size: 176 flags: FLAGS_NONE

    // m_pBlenderGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_EventToFreezeBlendValue m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_EventToCrossBlend m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_fBlendParameter m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_fTransitionDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags:  enum: 
    // m_eBlendCurve m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 128 flags:  enum: BlendCurve
    // m_pTransitionBlenderGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|ALIGN_8|FLAGS_NONE enum: 
    // m_pTransitionEffect m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|ALIGN_8|FLAGS_NONE enum: 
    // m_currentMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 168 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSCyclicBlendTransitionGenerator : hkbGenerator
    {

        public hkbGenerator /*pointer struct*/ m_pBlenderGenerator;
        public hkbEventProperty/*struct void*/ m_EventToFreezeBlendValue;
        public hkbEventProperty/*struct void*/ m_EventToCrossBlend;
        public float m_fBlendParameter;
        public float m_fTransitionDuration;
        public sbyte m_eBlendCurve;
        public dynamic /* POINTER VOID */ m_pTransitionBlenderGenerator;
        public dynamic /* POINTER VOID */ m_pTransitionEffect;
        public sbyte m_currentMode;

        public override uint Signature => 0x5119eb06;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_pBlenderGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_EventToFreezeBlendValue = new hkbEventProperty();
            m_EventToFreezeBlendValue.Read(des,br);
            m_EventToCrossBlend = new hkbEventProperty();
            m_EventToCrossBlend.Read(des,br);
            m_fBlendParameter = br.ReadSingle();
            m_fTransitionDuration = br.ReadSingle();
            m_eBlendCurve = br.ReadSByte();
            br.Position += 15;
            des.ReadEmptyPointer(br);/* m_pTransitionBlenderGenerator POINTER VOID */
            br.Position += 8;
            des.ReadEmptyPointer(br);/* m_pTransitionEffect POINTER VOID */
            m_currentMode = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
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
            s.WriteVoidPointer(bw);/* m_pTransitionBlenderGenerator POINTER VOID */
            bw.Position += 8;
            s.WriteVoidPointer(bw);/* m_pTransitionEffect POINTER VOID */
            s.WriteSByte(bw, m_currentMode);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

