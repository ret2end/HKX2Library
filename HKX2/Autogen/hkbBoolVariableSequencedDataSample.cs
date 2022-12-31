using System.Xml.Linq;

namespace HKX2
{
    // hkbBoolVariableSequencedDataSample Signatire: 0x514763dc size: 8 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_value m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkbBoolVariableSequencedDataSample : IHavokObject
    {
        public float m_time;
        public bool m_value;

        public virtual uint Signature => 0x514763dc;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_time = br.ReadSingle();
            m_value = br.ReadBoolean();
            br.Position += 3;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_time);
            bw.WriteBoolean(m_value);
            bw.Position += 3;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_time), m_time);
            xs.WriteBoolean(xe, nameof(m_value), m_value);
        }
    }
}

