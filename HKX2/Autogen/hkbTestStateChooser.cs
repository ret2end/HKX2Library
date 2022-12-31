using System.Xml.Linq;

namespace HKX2
{
    // hkbTestStateChooser Signatire: 0xc0fcc436 size: 32 flags: FLAGS_NONE

    // m_int m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_real m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_string m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbTestStateChooser : hkbStateChooser
    {
        public int m_int;
        public float m_real;
        public string m_string;

        public override uint Signature => 0xc0fcc436;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_int = br.ReadInt32();
            m_real = br.ReadSingle();
            m_string = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_int);
            bw.WriteSingle(m_real);
            s.WriteStringPointer(bw, m_string);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_int), m_int);
            xs.WriteFloat(xe, nameof(m_real), m_real);
            xs.WriteString(xe, nameof(m_string), m_string);
        }
    }
}

