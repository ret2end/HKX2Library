using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxMaterialEffect Signatire: 0x1d39f925 size: 48 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: EffectType
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkxMaterialEffect : hkReferencedObject
    {
        public string m_name;
        public byte m_type;
        public List<byte> m_data;

        public override uint Signature => 0x1d39f925;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_type = br.ReadByte();
            br.Position += 7;
            m_data = des.ReadByteArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteByte(bw, m_type);
            bw.Position += 7;
            s.WriteByteArray(bw, m_data);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteEnum<EffectType, byte>(xe, nameof(m_type), m_type);
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
        }
    }
}

