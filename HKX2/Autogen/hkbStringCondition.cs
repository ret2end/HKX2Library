using System.Xml.Linq;

namespace HKX2
{
    // hkbStringCondition Signatire: 0x5ab50487 size: 24 flags: FLAGS_NONE

    // m_conditionString m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbStringCondition : hkbCondition
    {
        public string m_conditionString;

        public override uint Signature => 0x5ab50487;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_conditionString = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_conditionString);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_conditionString), m_conditionString);
        }
    }
}

