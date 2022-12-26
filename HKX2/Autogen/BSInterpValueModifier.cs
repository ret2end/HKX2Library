using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSInterpValueModifier Signatire: 0x29adc802 size: 104 flags: FLAGS_NONE

    // m_source m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_target m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_result m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_gain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSInterpValueModifier : hkbModifier
    {

        public float m_source;
        public float m_target;
        public float m_result;
        public float m_gain;
        public float m_timeStep;

        public override uint Signature => 0x29adc802;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_source = br.ReadSingle();
            m_target = br.ReadSingle();
            m_result = br.ReadSingle();
            m_gain = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_source);
            bw.WriteSingle(m_target);
            bw.WriteSingle(m_result);
            bw.WriteSingle(m_gain);
            bw.WriteSingle(m_timeStep);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

