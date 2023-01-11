using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkMemoryResourceHandle Signatire: 0xbffac086 size: 48 flags: FLAGS_NONE

    // m_variant m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_references m_class: hkMemoryResourceHandleExternalLink Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkMemoryResourceHandle : hkResourceHandle
    {
        public hkReferencedObject? m_variant { set; get; } = default;
        public string m_name { set; get; } = "";
        public IList<hkMemoryResourceHandleExternalLink> m_references { set; get; } = new List<hkMemoryResourceHandleExternalLink>();

        public override uint Signature => 0xbffac086;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_variant = des.ReadClassPointer<hkReferencedObject>(br);
            m_name = des.ReadStringPointer(br);
            m_references = des.ReadClassArray<hkMemoryResourceHandleExternalLink>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_variant);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray(bw, m_references);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_variant = xd.ReadClassPointer<hkReferencedObject>(xe, nameof(m_variant));
            m_name = xd.ReadString(xe, nameof(m_name));
            m_references = xd.ReadClassArray<hkMemoryResourceHandleExternalLink>(xe, nameof(m_references));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_variant), m_variant);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassArray<hkMemoryResourceHandleExternalLink>(xe, nameof(m_references), m_references);
        }
    }
}

