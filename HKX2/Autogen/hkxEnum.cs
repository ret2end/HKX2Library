using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxEnum Signatire: 0xc4e1211 size: 32 flags: FLAGS_NONE

    // m_items m_class: hkxEnumItem Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxEnum : hkReferencedObject
    {

        public List<hkxEnumItem> m_items;

        public override uint Signature => 0xc4e1211;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_items = des.ReadClassArray<hkxEnumItem>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkxEnumItem>(bw, m_items);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

