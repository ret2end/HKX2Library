using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxVertexDescription Signatire: 0x2df6313d size: 16 flags: FLAGS_NONE

    // m_decls m_class: hkxVertexDescriptionElementDecl Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkxVertexDescription : IHavokObject
    {
        public IList<hkxVertexDescriptionElementDecl> m_decls { set; get; } = new List<hkxVertexDescriptionElementDecl>();

        public virtual uint Signature => 0x2df6313d;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_decls = des.ReadClassArray<hkxVertexDescriptionElementDecl>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_decls);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_decls = xd.ReadClassArray<hkxVertexDescriptionElementDecl>(xe, nameof(m_decls));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassArray<hkxVertexDescriptionElementDecl>(xe, nameof(m_decls), m_decls);
        }
    }
}

