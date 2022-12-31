using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbSequenceStringData Signatire: 0x6a5094e3 size: 48 flags: FLAGS_NONE

    // m_eventNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_variableNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbSequenceStringData : hkReferencedObject
    {
        public List<string> m_eventNames;
        public List<string> m_variableNames;

        public override uint Signature => 0x6a5094e3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_eventNames = des.ReadStringPointerArray(br);
            m_variableNames = des.ReadStringPointerArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_eventNames);
            s.WriteStringPointerArray(bw, m_variableNames);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteStringArray(xe, nameof(m_eventNames), m_eventNames);
            xs.WriteStringArray(xe, nameof(m_variableNames), m_variableNames);
        }
    }
}

