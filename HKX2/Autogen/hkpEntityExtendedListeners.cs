using System.Xml.Linq;

namespace HKX2
{
    // hkpEntityExtendedListeners Signatire: 0xf557023c size: 32 flags: FLAGS_NONE

    // m_activationListeners m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_entityListeners m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpEntityExtendedListeners : IHavokObject
    {
        public hkpEntitySmallArraySerializeOverrideType m_activationListeners = new hkpEntitySmallArraySerializeOverrideType();
        public hkpEntitySmallArraySerializeOverrideType m_entityListeners = new hkpEntitySmallArraySerializeOverrideType();

        public virtual uint Signature => 0xf557023c;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_activationListeners = new hkpEntitySmallArraySerializeOverrideType();
            m_activationListeners.Read(des, br);
            m_entityListeners = new hkpEntitySmallArraySerializeOverrideType();
            m_entityListeners.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_activationListeners.Write(s, bw);
            m_entityListeners.Write(s, bw);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_activationListeners = new hkpEntitySmallArraySerializeOverrideType();
            m_entityListeners = new hkpEntitySmallArraySerializeOverrideType();
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_activationListeners));
            xs.WriteSerializeIgnored(xe, nameof(m_entityListeners));
        }
    }
}

