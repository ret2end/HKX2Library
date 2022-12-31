using System.Xml.Linq;

namespace HKX2
{
    // hkaAnnotationTrackAnnotation Signatire: 0x623bf34f size: 16 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_text m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkaAnnotationTrackAnnotation : IHavokObject
    {
        public float m_time;
        public string m_text;

        public virtual uint Signature => 0x623bf34f;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_time = br.ReadSingle();
            br.Position += 4;
            m_text = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_time);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_text);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_time), m_time);
            xs.WriteString(xe, nameof(m_text), m_text);
        }
    }
}

