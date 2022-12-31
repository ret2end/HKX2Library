using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkBitField Signatire: 0xda41bd9b size: 24 flags: FLAGS_NONE

    // m_words m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_numBits m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkBitField : IHavokObject
    {
        public List<uint> m_words;
        public int m_numBits;

        public virtual uint Signature => 0xda41bd9b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_words = des.ReadUInt32Array(br);
            m_numBits = br.ReadInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteUInt32Array(bw, m_words);
            bw.WriteInt32(m_numBits);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumberArray(xe, nameof(m_words), m_words);
            xs.WriteNumber(xe, nameof(m_numBits), m_numBits);
        }
    }
}

