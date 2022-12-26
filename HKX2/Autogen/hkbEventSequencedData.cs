using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventSequencedData Signatire: 0x76798eb8 size: 32 flags: FLAGS_NONE

    // m_events m_class: hkbEventSequencedDataSequencedEvent Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbEventSequencedData : hkbSequencedData
    {

        public List<hkbEventSequencedDataSequencedEvent> m_events;

        public override uint Signature => 0x76798eb8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_events = des.ReadClassArray<hkbEventSequencedDataSequencedEvent>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbEventSequencedDataSequencedEvent>(bw, m_events);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

