using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BGSGamebryoSequenceGenerator Signatire: 0xc8df2d77 size: 112 flags: FLAGS_NONE

    // m_pSequence m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_eBlendModeFunction m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 80 flags:  enum: BlendModeFunction
    // m_fPercent m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_events m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 88 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_fTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bDelayedActivate m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 108 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bLooping m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 109 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class BGSGamebryoSequenceGenerator : hkbGenerator
    {

        public string m_pSequence;
        public sbyte m_eBlendModeFunction;
        public float m_fPercent;
        public List<ulong> m_events;
        public float m_fTime;
        public bool m_bDelayedActivate;
        public bool m_bLooping;

        public override uint Signature => 0xc8df2d77;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_pSequence = des.ReadStringPointer(br);//m_pSequence = br.ReadASCII();
            m_eBlendModeFunction = br.ReadSByte();
            br.Position += 3;
            m_fPercent = br.ReadSingle();
            des.ReadEmptyArray(br); //m_events
            m_fTime = br.ReadSingle();
            m_bDelayedActivate = br.ReadBoolean();
            m_bLooping = br.ReadBoolean();
            br.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_pSequence);//bw.WriteASCII(m_pSequence, true);
            s.WriteSByte(bw, m_eBlendModeFunction);
            bw.Position += 3;
            bw.WriteSingle(m_fPercent);
            s.WriteVoidArray(bw); // m_events
            bw.WriteSingle(m_fTime);
            bw.WriteBoolean(m_bDelayedActivate);
            bw.WriteBoolean(m_bLooping);
            bw.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

