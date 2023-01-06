using System.Xml.Linq;

namespace HKX2
{
    // hkpPoweredChainMapperTarget Signatire: 0xf651c74d size: 16 flags: FLAGS_NONE

    // m_chain m_class: hkpPoweredChainData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_infoIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpPoweredChainMapperTarget : IHavokObject
    {
        public hkpPoweredChainData m_chain;
        public int m_infoIndex;

        public virtual uint Signature => 0xf651c74d;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_chain = des.ReadClassPointer<hkpPoweredChainData>(br);
            m_infoIndex = br.ReadInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_chain);
            bw.WriteInt32(m_infoIndex);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_chain = xd.ReadClassPointer<hkpPoweredChainData>(xe, nameof(m_chain));
            m_infoIndex = xd.ReadInt32(xe, nameof(m_infoIndex));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_chain), m_chain);
            xs.WriteNumber(xe, nameof(m_infoIndex), m_infoIndex);
        }
    }
}

