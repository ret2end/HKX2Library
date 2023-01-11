using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxVertexBuffer Signatire: 0x4ab10615 size: 136 flags: FLAGS_NONE

    // m_data m_class: hkxVertexBufferVertexData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_desc m_class: hkxVertexDescription Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    public partial class hkxVertexBuffer : hkReferencedObject
    {
        public hkxVertexBufferVertexData m_data { set; get; } = new();
        public hkxVertexDescription m_desc { set; get; } = new();

        public override uint Signature => 0x4ab10615;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_data.Read(des, br);
            m_desc.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_data.Write(s, bw);
            m_desc.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_data = xd.ReadClass<hkxVertexBufferVertexData>(xe, nameof(m_data));
            m_desc = xd.ReadClass<hkxVertexDescription>(xe, nameof(m_desc));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkxVertexBufferVertexData>(xe, nameof(m_data), m_data);
            xs.WriteClass<hkxVertexDescription>(xe, nameof(m_desc), m_desc);
        }
    }
}

