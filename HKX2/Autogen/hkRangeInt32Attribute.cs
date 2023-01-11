using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkRangeInt32Attribute Signatire: 0x4846be29 size: 16 flags: FLAGS_NONE

    // m_absmin m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_absmax m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_softmin m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_softmax m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkRangeInt32Attribute : IHavokObject
    {
        public int m_absmin { set; get; } = default;
        public int m_absmax { set; get; } = default;
        public int m_softmin { set; get; } = default;
        public int m_softmax { set; get; } = default;

        public virtual uint Signature => 0x4846be29;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_absmin = br.ReadInt32();
            m_absmax = br.ReadInt32();
            m_softmin = br.ReadInt32();
            m_softmax = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_absmin);
            bw.WriteInt32(m_absmax);
            bw.WriteInt32(m_softmin);
            bw.WriteInt32(m_softmax);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_absmin = xd.ReadInt32(xe, nameof(m_absmin));
            m_absmax = xd.ReadInt32(xe, nameof(m_absmax));
            m_softmin = xd.ReadInt32(xe, nameof(m_softmin));
            m_softmax = xd.ReadInt32(xe, nameof(m_softmax));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_absmin), m_absmin);
            xs.WriteNumber(xe, nameof(m_absmax), m_absmax);
            xs.WriteNumber(xe, nameof(m_softmin), m_softmin);
            xs.WriteNumber(xe, nameof(m_softmax), m_softmax);
        }
    }
}

