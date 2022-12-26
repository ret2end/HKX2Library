using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpEntityExtendedListeners Signatire: 0xf557023c size: 32 flags: FLAGS_NONE

    // m_activationListeners m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_entityListeners m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpEntityExtendedListeners : IHavokObject
    {

        public hkpEntitySmallArraySerializeOverrideType/*struct void*/ m_activationListeners;
        public hkpEntitySmallArraySerializeOverrideType/*struct void*/ m_entityListeners;

        public uint Signature => 0xf557023c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_activationListeners = new hkpEntitySmallArraySerializeOverrideType();
            m_activationListeners.Read(des,br);
            m_entityListeners = new hkpEntitySmallArraySerializeOverrideType();
            m_entityListeners.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_activationListeners.Write(s, bw);
            m_entityListeners.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

