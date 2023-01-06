using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorGraphStringData Signatire: 0xc713064e size: 80 flags: FLAGS_NONE

    // m_eventNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_attributeNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_variableNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_characterPropertyNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkbBehaviorGraphStringData : hkReferencedObject
    {
        public List<string> m_eventNames;
        public List<string> m_attributeNames;
        public List<string> m_variableNames;
        public List<string> m_characterPropertyNames;

        public override uint Signature => 0xc713064e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_eventNames = des.ReadStringPointerArray(br);
            m_attributeNames = des.ReadStringPointerArray(br);
            m_variableNames = des.ReadStringPointerArray(br);
            m_characterPropertyNames = des.ReadStringPointerArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_eventNames);
            s.WriteStringPointerArray(bw, m_attributeNames);
            s.WriteStringPointerArray(bw, m_variableNames);
            s.WriteStringPointerArray(bw, m_characterPropertyNames);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_eventNames = xd.ReadStringArray(xe, nameof(m_eventNames));
            m_attributeNames = xd.ReadStringArray(xe, nameof(m_attributeNames));
            m_variableNames = xd.ReadStringArray(xe, nameof(m_variableNames));
            m_characterPropertyNames = xd.ReadStringArray(xe, nameof(m_characterPropertyNames));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteStringArray(xe, nameof(m_eventNames), m_eventNames);
            xs.WriteStringArray(xe, nameof(m_attributeNames), m_attributeNames);
            xs.WriteStringArray(xe, nameof(m_variableNames), m_variableNames);
            xs.WriteStringArray(xe, nameof(m_characterPropertyNames), m_characterPropertyNames);
        }
    }
}

