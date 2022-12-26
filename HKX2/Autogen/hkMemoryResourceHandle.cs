using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkMemoryResourceHandle Signatire: 0xbffac086 size: 48 flags: FLAGS_NONE

    // m_variant m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_references m_class: hkMemoryResourceHandleExternalLink Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkMemoryResourceHandle : hkResourceHandle
    {

        public hkReferencedObject /*pointer struct*/ m_variant;
        public string m_name;
        public List<hkMemoryResourceHandleExternalLink> m_references;

        public override uint Signature => 0xbffac086;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_variant = des.ReadClassPointer<hkReferencedObject>(br);
            m_name = des.ReadStringPointer(br);
            m_references = des.ReadClassArray<hkMemoryResourceHandleExternalLink>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_variant);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray<hkMemoryResourceHandleExternalLink>(bw, m_references);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

