using System.Xml.Linq;

namespace HKX2
{
    // hkxMaterialTextureStage Signatire: 0xfa6facb2 size: 16 flags: FLAGS_NONE

    // m_texture m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_usageHint m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 8 flags: FLAGS_NONE enum: TextureType
    // m_tcoordChannel m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkxMaterialTextureStage : IHavokObject
    {
        public hkReferencedObject m_texture;
        public int m_usageHint;
        public int m_tcoordChannel;

        public virtual uint Signature => 0xfa6facb2;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_texture = des.ReadClassPointer<hkReferencedObject>(br);
            m_usageHint = br.ReadInt32();
            m_tcoordChannel = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_texture);
            s.WriteInt32(bw, m_usageHint);
            bw.WriteInt32(m_tcoordChannel);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_texture = xd.ReadClassPointer<hkReferencedObject>(xe, nameof(m_texture));
            m_usageHint = xd.ReadFlag<TextureType, int>(xe, nameof(m_usageHint));
            m_tcoordChannel = xd.ReadInt32(xe, nameof(m_tcoordChannel));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_texture), m_texture);
            xs.WriteEnum<TextureType, int>(xe, nameof(m_usageHint), m_usageHint);
            xs.WriteNumber(xe, nameof(m_tcoordChannel), m_tcoordChannel);
        }
    }
}

