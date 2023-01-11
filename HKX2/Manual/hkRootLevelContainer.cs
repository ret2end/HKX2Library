using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkRootLevelContainer Signatire: 0x2772c11e size: 16 flags: FLAGS_NONE

    // m_namedVariants m_class: hkRootLevelContainerNamedVariant Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 

    public partial class hkRootLevelContainer : IHavokObject
    {

        public List<hkRootLevelContainerNamedVariant> m_namedVariants { get; set; } = new();
        public List<string> m_test { get; set; } = new();

        public uint Signature => 0x2772c11e;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_namedVariants = des.ReadClassArray<hkRootLevelContainerNamedVariant>(br);
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_namedVariants);
        }

        public void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_namedVariants = xd.ReadClassArray<hkRootLevelContainerNamedVariant>(xe, nameof(m_namedVariants));
        }

        public void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassArray(xe, nameof(m_namedVariants), m_namedVariants);
        }
    }
}

