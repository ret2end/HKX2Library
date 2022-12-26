using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventRangeData Signatire: 0x6cb92c76 size: 32 flags: FLAGS_NONE

    // m_upperBound m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_event m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 24 flags:  enum: EventRangeMode
    
    public class hkbEventRangeData : IHavokObject
    {

        public float m_upperBound;
        public hkbEventProperty/*struct void*/ m_event;
        public sbyte m_eventMode;

        public uint Signature => 0x6cb92c76;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_upperBound = br.ReadSingle();
            br.Position += 4;
            m_event = new hkbEventProperty();
            m_event.Read(des,br);
            m_eventMode = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_upperBound);
            bw.Position += 4;
            m_event.Write(s, bw);
            s.WriteSByte(bw, m_eventMode);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

