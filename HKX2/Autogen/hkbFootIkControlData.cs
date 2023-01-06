using System.Xml.Linq;

namespace HKX2
{
    // hkbFootIkControlData Signatire: 0xa111b704 size: 48 flags: FLAGS_NONE

    // m_gains m_class: hkbFootIkGains Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkbFootIkControlData : IHavokObject
    {
        public hkbFootIkGains m_gains = new hkbFootIkGains();

        public virtual uint Signature => 0xa111b704;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_gains = new hkbFootIkGains();
            m_gains.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_gains.Write(s, bw);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_gains = xd.ReadClass<hkbFootIkGains>(xe, nameof(m_gains));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbFootIkGains>(xe, nameof(m_gains), m_gains);
        }
    }
}

