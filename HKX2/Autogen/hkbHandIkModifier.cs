using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbHandIkModifier Signatire: 0xef8bc2f7 size: 120 flags: FLAGS_NONE

    // m_hands m_class: hkbHandIkModifierHand Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_fadeInOutCurve m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 96 flags:  enum: BlendCurve
    // m_internalHandData m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbHandIkModifier : hkbModifier
    {

        public List<hkbHandIkModifierHand> m_hands;
        public sbyte m_fadeInOutCurve;
        public List<ulong> m_internalHandData;

        public override uint Signature => 0xef8bc2f7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_hands = des.ReadClassArray<hkbHandIkModifierHand>(br);
            m_fadeInOutCurve = br.ReadSByte();
            br.Position += 7;
            des.ReadEmptyArray(br); //m_internalHandData

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbHandIkModifierHand>(bw, m_hands);
            s.WriteSByte(bw, m_fadeInOutCurve);
            bw.Position += 7;
            s.WriteVoidArray(bw); // m_internalHandData

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

