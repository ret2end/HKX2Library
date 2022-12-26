using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkMemoryResourceContainer Signatire: 0x4762f92a size: 64 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_parent m_class: hkMemoryResourceContainer Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_resourceHandles m_class: hkMemoryResourceHandle Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    // m_children m_class: hkMemoryResourceContainer Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkMemoryResourceContainer : hkResourceContainer
    {

        public string m_name;
        public hkMemoryResourceContainer /*pointer struct*/ m_parent;
        public List<hkMemoryResourceHandle> m_resourceHandles;
        public List<hkMemoryResourceContainer> m_children;

        public override uint Signature => 0x4762f92a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_parent = des.ReadClassPointer<hkMemoryResourceContainer>(br);
            m_resourceHandles = des.ReadClassPointerArray<hkMemoryResourceHandle>(br);
            m_children = des.ReadClassPointerArray<hkMemoryResourceContainer>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_parent);
            s.WriteClassPointerArray<hkMemoryResourceHandle>(bw, m_resourceHandles);
            s.WriteClassPointerArray<hkMemoryResourceContainer>(bw, m_children);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

