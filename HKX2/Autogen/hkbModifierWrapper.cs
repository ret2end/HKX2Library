using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbModifierWrapper Signatire: 0x3697e044 size: 88 flags: FLAGS_NONE

    // m_modifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkbModifierWrapper : hkbModifier
    {

        public hkbModifier /*pointer struct*/ m_modifier;

        public override uint Signature => 0x3697e044;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_modifier = des.ReadClassPointer<hkbModifier>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_modifier);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

