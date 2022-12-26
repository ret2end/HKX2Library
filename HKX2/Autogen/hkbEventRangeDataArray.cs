using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventRangeDataArray Signatire: 0x330a56ee size: 32 flags: FLAGS_NONE

    // m_eventData m_class: hkbEventRangeData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbEventRangeDataArray : hkReferencedObject
    {

        public List<hkbEventRangeData> m_eventData;

        public override uint Signature => 0x330a56ee;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_eventData = des.ReadClassArray<hkbEventRangeData>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbEventRangeData>(bw, m_eventData);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

