using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEvaluateExpressionModifierInternalExpressionData Signatire: 0xb8686f6b size: 2 flags: FLAGS_NONE

    // m_raisedEvent m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_wasTrueInPreviousFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 1 flags:  enum: 
    
    public class hkbEvaluateExpressionModifierInternalExpressionData : IHavokObject
    {

        public bool m_raisedEvent;
        public bool m_wasTrueInPreviousFrame;

        public uint Signature => 0xb8686f6b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_raisedEvent = br.ReadBoolean();
            m_wasTrueInPreviousFrame = br.ReadBoolean();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBoolean(m_raisedEvent);
            bw.WriteBoolean(m_wasTrueInPreviousFrame);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

