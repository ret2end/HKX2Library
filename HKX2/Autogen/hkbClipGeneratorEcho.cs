using System.Xml.Linq;

namespace HKX2
{
    // hkbClipGeneratorEcho Signatire: 0x750edf40 size: 16 flags: FLAGS_NONE

    // m_offsetLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_weight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_dwdt m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkbClipGeneratorEcho : IHavokObject
    {
        public float m_offsetLocalTime;
        public float m_weight;
        public float m_dwdt;

        public virtual uint Signature => 0x750edf40;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_offsetLocalTime = br.ReadSingle();
            m_weight = br.ReadSingle();
            m_dwdt = br.ReadSingle();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_offsetLocalTime);
            bw.WriteSingle(m_weight);
            bw.WriteSingle(m_dwdt);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_offsetLocalTime), m_offsetLocalTime);
            xs.WriteFloat(xe, nameof(m_weight), m_weight);
            xs.WriteFloat(xe, nameof(m_dwdt), m_dwdt);
        }
    }
}

