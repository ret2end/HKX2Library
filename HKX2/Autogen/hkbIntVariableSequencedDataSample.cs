using System.Xml.Linq;

namespace HKX2
{
    // hkbIntVariableSequencedDataSample Signatire: 0xbe7ac63c size: 8 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_value m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkbIntVariableSequencedDataSample : IHavokObject
    {
        public float m_time;
        public int m_value;

        public virtual uint Signature => 0xbe7ac63c;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_time = br.ReadSingle();
            m_value = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_time);
            bw.WriteInt32(m_value);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_time), m_time);
            xs.WriteNumber(xe, nameof(m_value), m_value);
        }
    }
}

