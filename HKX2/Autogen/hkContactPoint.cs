using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkContactPoint Signatire: 0x91d7dd8e size: 32 flags: FLAGS_NONE

    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_separatingNormal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkContactPoint : IHavokObject
    {
        public Vector4 m_position { set; get; } = default;
        public Vector4 m_separatingNormal { set; get; } = default;

        public virtual uint Signature => 0x91d7dd8e;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_position = br.ReadVector4();
            m_separatingNormal = br.ReadVector4();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_position);
            bw.WriteVector4(m_separatingNormal);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_position = xd.ReadVector4(xe, nameof(m_position));
            m_separatingNormal = xd.ReadVector4(xe, nameof(m_separatingNormal));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_position), m_position);
            xs.WriteVector4(xe, nameof(m_separatingNormal), m_separatingNormal);
        }
    }
}

