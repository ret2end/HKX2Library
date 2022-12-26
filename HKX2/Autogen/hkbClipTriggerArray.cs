using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbClipTriggerArray Signatire: 0x59c23a0f size: 32 flags: FLAGS_NONE

    // m_triggers m_class: hkbClipTrigger Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbClipTriggerArray : hkReferencedObject
    {

        public List<hkbClipTrigger> m_triggers;

        public override uint Signature => 0x59c23a0f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_triggers = des.ReadClassArray<hkbClipTrigger>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbClipTrigger>(bw, m_triggers);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

