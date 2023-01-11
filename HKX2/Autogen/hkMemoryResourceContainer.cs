using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkMemoryResourceContainer Signatire: 0x4762f92a size: 64 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_parent m_class: hkMemoryResourceContainer Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_resourceHandles m_class: hkMemoryResourceHandle Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_children m_class: hkMemoryResourceContainer Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkMemoryResourceContainer : hkResourceContainer
    {
        public string m_name { set; get; } = "";
        private hkMemoryResourceContainer? m_parent { set; get; } = default;
        public IList<hkMemoryResourceHandle> m_resourceHandles { set; get; } = new List<hkMemoryResourceHandle>();
        public IList<hkMemoryResourceContainer> m_children { set; get; } = new List<hkMemoryResourceContainer>();

        public override uint Signature => 0x4762f92a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_parent = des.ReadClassPointer<hkMemoryResourceContainer>(br);
            m_resourceHandles = des.ReadClassPointerArray<hkMemoryResourceHandle>(br);
            m_children = des.ReadClassPointerArray<hkMemoryResourceContainer>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_parent);
            s.WriteClassPointerArray(bw, m_resourceHandles);
            s.WriteClassPointerArray(bw, m_children);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_name = xd.ReadString(xe, nameof(m_name));
            m_resourceHandles = xd.ReadClassPointerArray<hkMemoryResourceHandle>(xe, nameof(m_resourceHandles));
            m_children = xd.ReadClassPointerArray<hkMemoryResourceContainer>(xe, nameof(m_children));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteSerializeIgnored(xe, nameof(m_parent));
            xs.WriteClassPointerArray<hkMemoryResourceHandle>(xe, nameof(m_resourceHandles), m_resourceHandles);
            xs.WriteClassPointerArray<hkMemoryResourceContainer>(xe, nameof(m_children), m_children);
        }
    }
}

