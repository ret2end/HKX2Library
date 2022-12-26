using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSequenceStringData Signatire: 0x6a5094e3 size: 48 flags: FLAGS_NONE

    // m_eventNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags:  enum: 
    // m_variableNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkbSequenceStringData : hkReferencedObject
    {

        public List<string> m_eventNames;
        public List<string> m_variableNames;

        public override uint Signature => 0x6a5094e3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_eventNames = des.ReadStringPointerArray(br);
            m_variableNames = des.ReadStringPointerArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_eventNames);
            s.WriteStringPointerArray(bw, m_variableNames);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

