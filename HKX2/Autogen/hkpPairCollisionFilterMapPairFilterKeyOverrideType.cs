using System.Xml.Linq;

namespace HKX2
{
    // hkpPairCollisionFilterMapPairFilterKeyOverrideType Signatire: 0x36195969 size: 16 flags: FLAGS_NONE

    // m_elem m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_numElems m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_hashMod m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkpPairCollisionFilterMapPairFilterKeyOverrideType : IHavokObject
    {
        public dynamic m_elem;
        public int m_numElems;
        public int m_hashMod;

        public virtual uint Signature => 0x36195969;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            m_numElems = br.ReadInt32();
            m_hashMod = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_numElems);
            bw.WriteInt32(m_hashMod);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_elem = default;
            m_numElems = xd.ReadInt32(xe, nameof(m_numElems));
            m_hashMod = xd.ReadInt32(xe, nameof(m_hashMod));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_elem));
            xs.WriteNumber(xe, nameof(m_numElems), m_numElems);
            xs.WriteNumber(xe, nameof(m_hashMod), m_hashMod);
        }
    }
}

