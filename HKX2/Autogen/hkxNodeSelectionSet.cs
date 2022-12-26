using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxNodeSelectionSet Signatire: 0xd753fc4d size: 56 flags: FLAGS_NONE

    // m_selectedNodes m_class: hkxNode Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkxNodeSelectionSet : hkxAttributeHolder
    {

        public List<hkxNode> m_selectedNodes;
        public string m_name;

        public override uint Signature => 0xd753fc4d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_selectedNodes = des.ReadClassPointerArray<hkxNode>(br);
            m_name = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkxNode>(bw, m_selectedNodes);
            s.WriteStringPointer(bw, m_name);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

