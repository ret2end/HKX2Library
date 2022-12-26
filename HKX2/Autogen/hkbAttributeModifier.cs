using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbAttributeModifier Signatire: 0x1245d97d size: 96 flags: FLAGS_NONE

    // m_assignments m_class: hkbAttributeModifierAssignment Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkbAttributeModifier : hkbModifier
    {

        public List<hkbAttributeModifierAssignment> m_assignments;

        public override uint Signature => 0x1245d97d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_assignments = des.ReadClassArray<hkbAttributeModifierAssignment>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbAttributeModifierAssignment>(bw, m_assignments);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

