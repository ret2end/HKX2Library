using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxAttributeHolder Signatire: 0x7468cc44 size: 32 flags: FLAGS_NONE

    // m_attributeGroups m_class: hkxAttributeGroup Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkxAttributeHolder : hkReferencedObject
    {
        public List<hkxAttributeGroup> m_attributeGroups;

        public override uint Signature => 0x7468cc44;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_attributeGroups = des.ReadClassArray<hkxAttributeGroup>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkxAttributeGroup>(bw, m_attributeGroups);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkxAttributeGroup>(xe, nameof(m_attributeGroups), m_attributeGroups);
        }
    }
}

