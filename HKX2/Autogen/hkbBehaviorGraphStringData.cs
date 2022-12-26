using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorGraphStringData Signatire: 0xc713064e size: 80 flags: FLAGS_NONE

    // m_eventNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags:  enum: 
    // m_attributeNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags:  enum: 
    // m_variableNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 48 flags:  enum: 
    // m_characterPropertyNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkbBehaviorGraphStringData : hkReferencedObject
    {

        public List<string> m_eventNames;
        public List<string> m_attributeNames;
        public List<string> m_variableNames;
        public List<string> m_characterPropertyNames;

        public override uint Signature => 0xc713064e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_eventNames = des.ReadStringPointerArray(br);
            m_attributeNames = des.ReadStringPointerArray(br);
            m_variableNames = des.ReadStringPointerArray(br);
            m_characterPropertyNames = des.ReadStringPointerArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_eventNames);
            s.WriteStringPointerArray(bw, m_attributeNames);
            s.WriteStringPointerArray(bw, m_variableNames);
            s.WriteStringPointerArray(bw, m_characterPropertyNames);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

