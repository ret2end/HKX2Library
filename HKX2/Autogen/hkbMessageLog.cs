using System.Xml.Linq;

namespace HKX2
{
    // hkbMessageLog Signatire: 0x26a196c5 size: 16 flags: FLAGS_NONE

    // m_messages m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_maxMessages m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbMessageLog : IHavokObject
    {
        public dynamic m_messages;
        public int m_maxMessages;

        public virtual uint Signature => 0x26a196c5;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            m_maxMessages = br.ReadInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_maxMessages);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_messages));
            xs.WriteSerializeIgnored(xe, nameof(m_maxMessages));
        }
    }
}

