using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxEnvironment Signatire: 0x41e1aa5 size: 32 flags: FLAGS_NONE

    // m_variables m_class: hkxEnvironmentVariable Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkxEnvironment : hkReferencedObject
    {
        public List<hkxEnvironmentVariable> m_variables = new List<hkxEnvironmentVariable>();

        public override uint Signature => 0x41e1aa5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_variables = des.ReadClassArray<hkxEnvironmentVariable>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkxEnvironmentVariable>(bw, m_variables);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_variables = xd.ReadClassArray<hkxEnvironmentVariable>(xe, nameof(m_variables));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkxEnvironmentVariable>(xe, nameof(m_variables), m_variables);
        }
    }
}

