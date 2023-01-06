using System.Xml.Linq;

namespace HKX2
{
    // hkbRealVariableSequencedDataSample Signatire: 0xbb708bbd size: 8 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_value m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkbRealVariableSequencedDataSample : IHavokObject
    {
        public float m_time;
        public float m_value;

        public virtual uint Signature => 0xbb708bbd;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_time = br.ReadSingle();
            m_value = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_time);
            bw.WriteSingle(m_value);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_time = xd.ReadSingle(xe, nameof(m_time));
            m_value = xd.ReadSingle(xe, nameof(m_value));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_time), m_time);
            xs.WriteFloat(xe, nameof(m_value), m_value);
        }
    }
}

