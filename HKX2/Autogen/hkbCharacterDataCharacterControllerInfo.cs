using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterDataCharacterControllerInfo Signatire: 0xa0f415bf size: 24 flags: FLAGS_NONE

    // m_capsuleHeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_capsuleRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_characterControllerCinfo m_class: hkpCharacterControllerCinfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbCharacterDataCharacterControllerInfo : IHavokObject
    {
        public float m_capsuleHeight;
        public float m_capsuleRadius;
        public uint m_collisionFilterInfo;
        public hkpCharacterControllerCinfo m_characterControllerCinfo;

        public virtual uint Signature => 0xa0f415bf;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_capsuleHeight = br.ReadSingle();
            m_capsuleRadius = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            br.Position += 4;
            m_characterControllerCinfo = des.ReadClassPointer<hkpCharacterControllerCinfo>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_capsuleHeight);
            bw.WriteSingle(m_capsuleRadius);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_characterControllerCinfo);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_capsuleHeight), m_capsuleHeight);
            xs.WriteFloat(xe, nameof(m_capsuleRadius), m_capsuleRadius);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
            xs.WriteClassPointer(xe, nameof(m_characterControllerCinfo), m_characterControllerCinfo);
        }
    }
}

