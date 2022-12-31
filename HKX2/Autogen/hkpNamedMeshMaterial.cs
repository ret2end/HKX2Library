using System.Xml.Linq;

namespace HKX2
{
    // hkpNamedMeshMaterial Signatire: 0x66b42df1 size: 16 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpNamedMeshMaterial : hkpMeshMaterial
    {
        public string m_name;

        public override uint Signature => 0x66b42df1;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 4;
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
        }
    }
}

