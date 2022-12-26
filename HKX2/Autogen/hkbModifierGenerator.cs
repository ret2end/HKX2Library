using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbModifierGenerator Signatire: 0x1f81fae6 size: 88 flags: FLAGS_NONE

    // m_modifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 72 flags:  enum: 
    // m_generator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkbModifierGenerator : hkbGenerator
    {

        public hkbModifier /*pointer struct*/ m_modifier;
        public hkbGenerator /*pointer struct*/ m_generator;

        public override uint Signature => 0x1f81fae6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_modifier = des.ReadClassPointer<hkbModifier>(br);
            m_generator = des.ReadClassPointer<hkbGenerator>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_modifier);
            s.WriteClassPointer(bw, m_generator);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

