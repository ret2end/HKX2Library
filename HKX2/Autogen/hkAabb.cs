using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkAabb Signatire: 0x4a948b16 size: 32 flags: FLAGS_NONE

    // m_min m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_max m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkAabb : IHavokObject
    {
        public Vector4 m_min { set; get; } = default;
        public Vector4 m_max { set; get; } = default;

        public virtual uint Signature => 0x4a948b16;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_min = br.ReadVector4();
            m_max = br.ReadVector4();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_min);
            bw.WriteVector4(m_max);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_min = xd.ReadVector4(xe, nameof(m_min));
            m_max = xd.ReadVector4(xe, nameof(m_max));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_min), m_min);
            xs.WriteVector4(xe, nameof(m_max), m_max);
        }
    }
}

