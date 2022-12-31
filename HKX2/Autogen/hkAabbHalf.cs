using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkAabbHalf Signatire: 0x1d716a17 size: 16 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 6 offset: 0 flags: FLAGS_NONE enum: 
    // m_extras m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 2 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkAabbHalf : IHavokObject
    {
        public List<ushort> m_data;
        public List<ushort> m_extras;

        public virtual uint Signature => 0x1d716a17;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = des.ReadUInt16CStyleArray(br, 6);
            m_extras = des.ReadUInt16CStyleArray(br, 2);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteUInt16CStyleArray(bw, m_data);
            s.WriteUInt16CStyleArray(bw, m_extras);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
            xs.WriteNumberArray(xe, nameof(m_extras), m_extras);
        }
    }
}

