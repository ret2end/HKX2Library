using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkGeometryTriangle Signatire: 0x9687513b size: 16 flags: FLAGS_NONE

    // m_a m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_b m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_c m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_material m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkGeometryTriangle : IHavokObject
    {
        public int m_a { set; get; } = default;
        public int m_b { set; get; } = default;
        public int m_c { set; get; } = default;
        public int m_material { set; get; } = default;

        public virtual uint Signature => 0x9687513b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_a = br.ReadInt32();
            m_b = br.ReadInt32();
            m_c = br.ReadInt32();
            m_material = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_a);
            bw.WriteInt32(m_b);
            bw.WriteInt32(m_c);
            bw.WriteInt32(m_material);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_a = xd.ReadInt32(xe, nameof(m_a));
            m_b = xd.ReadInt32(xe, nameof(m_b));
            m_c = xd.ReadInt32(xe, nameof(m_c));
            m_material = xd.ReadInt32(xe, nameof(m_material));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_a), m_a);
            xs.WriteNumber(xe, nameof(m_b), m_b);
            xs.WriteNumber(xe, nameof(m_c), m_c);
            xs.WriteNumber(xe, nameof(m_material), m_material);
        }
    }
}

