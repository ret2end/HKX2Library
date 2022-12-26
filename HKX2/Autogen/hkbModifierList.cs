using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbModifierList Signatire: 0xa4180ca1 size: 96 flags: FLAGS_NONE

    // m_modifiers m_class: hkbModifier Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkbModifierList : hkbModifier
    {

        public List<hkbModifier> m_modifiers;

        public override uint Signature => 0xa4180ca1;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_modifiers = des.ReadClassPointerArray<hkbModifier>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkbModifier>(bw, m_modifiers);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

