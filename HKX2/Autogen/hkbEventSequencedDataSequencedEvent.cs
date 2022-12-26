using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventSequencedDataSequencedEvent Signatire: 0x9139b821 size: 32 flags: FLAGS_NONE

    // m_event m_class: hkbEvent Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbEventSequencedDataSequencedEvent : IHavokObject
    {

        public hkbEvent/*struct void*/ m_event;
        public float m_time;

        public uint Signature => 0x9139b821;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_event = new hkbEvent();
            m_event.Read(des,br);
            m_time = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_event.Write(s, bw);
            bw.WriteSingle(m_time);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

