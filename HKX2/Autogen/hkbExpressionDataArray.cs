using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbExpressionDataArray Signatire: 0x4b9ee1a2 size: 32 flags: FLAGS_NONE

    // m_expressionsData m_class: hkbExpressionData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbExpressionDataArray : hkReferencedObject
    {

        public List<hkbExpressionData> m_expressionsData;

        public override uint Signature => 0x4b9ee1a2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_expressionsData = des.ReadClassArray<hkbExpressionData>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbExpressionData>(bw, m_expressionsData);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

