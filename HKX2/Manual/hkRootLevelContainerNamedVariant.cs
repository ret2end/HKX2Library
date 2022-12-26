using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkRootLevelContainerNamedVariant Signatire: 0xb103a2cd size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_className m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_variant m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    
    public class hkRootLevelContainerNamedVariant : IHavokObject
    {

        public string m_name;
        public string m_className;
        public hkReferencedObject /*pointer struct*/ m_variant;

        public uint Signature => 0xb103a2cd;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);
            m_className = des.ReadStringPointer(br);
            m_variant = des.ReadClassPointer<hkReferencedObject>(br);

        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_className);
            s.WriteClassPointer(bw, m_variant);

        }
    }
}

