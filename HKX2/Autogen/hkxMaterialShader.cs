using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxMaterialShader Signatire: 0x28515eff size: 72 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: ShaderType
    // m_vertexEntryName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_geomEntryName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_pixelEntryName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    public partial class hkxMaterialShader : hkReferencedObject
    {
        public string m_name;
        public byte m_type;
        public string m_vertexEntryName;
        public string m_geomEntryName;
        public string m_pixelEntryName;
        public List<byte> m_data;

        public override uint Signature => 0x28515eff;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_type = br.ReadByte();
            br.Position += 7;
            m_vertexEntryName = des.ReadStringPointer(br);
            m_geomEntryName = des.ReadStringPointer(br);
            m_pixelEntryName = des.ReadStringPointer(br);
            m_data = des.ReadByteArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteByte(bw, m_type);
            bw.Position += 7;
            s.WriteStringPointer(bw, m_vertexEntryName);
            s.WriteStringPointer(bw, m_geomEntryName);
            s.WriteStringPointer(bw, m_pixelEntryName);
            s.WriteByteArray(bw, m_data);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_name = xd.ReadString(xe, nameof(m_name));
            m_type = xd.ReadFlag<ShaderType, byte>(xe, nameof(m_type));
            m_vertexEntryName = xd.ReadString(xe, nameof(m_vertexEntryName));
            m_geomEntryName = xd.ReadString(xe, nameof(m_geomEntryName));
            m_pixelEntryName = xd.ReadString(xe, nameof(m_pixelEntryName));
            m_data = xd.ReadByteArray(xe, nameof(m_data));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteEnum<ShaderType, byte>(xe, nameof(m_type), m_type);
            xs.WriteString(xe, nameof(m_vertexEntryName), m_vertexEntryName);
            xs.WriteString(xe, nameof(m_geomEntryName), m_geomEntryName);
            xs.WriteString(xe, nameof(m_pixelEntryName), m_pixelEntryName);
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
        }
    }
}

