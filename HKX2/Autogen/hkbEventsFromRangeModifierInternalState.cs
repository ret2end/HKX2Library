using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventsFromRangeModifierInternalState Signatire: 0xcc47b48d size: 32 flags: FLAGS_NONE

    // m_wasActiveInPreviousFrame m_class:  Type.TYPE_ARRAY Type.TYPE_BOOL arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbEventsFromRangeModifierInternalState : hkReferencedObject
    {

        public List<bool> m_wasActiveInPreviousFrame;

        public override uint Signature => 0xcc47b48d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_wasActiveInPreviousFrame = des.ReadBooleanArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteBooleanArray(bw, m_wasActiveInPreviousFrame);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

