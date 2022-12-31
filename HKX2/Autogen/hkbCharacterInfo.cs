using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterInfo Signatire: 0xd9709ff2 size: 32 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_event m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: Event
    // m_padding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    public partial class hkbCharacterInfo : hkReferencedObject
    {
        public ulong m_characterId;
        public byte m_event;
        public int m_padding;

        public override uint Signature => 0xd9709ff2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_event = br.ReadByte();
            br.Position += 3;
            m_padding = br.ReadInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteByte(bw, m_event);
            bw.Position += 3;
            bw.WriteInt32(m_padding);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteEnum<Event, byte>(xe, nameof(m_event), m_event);
            xs.WriteNumber(xe, nameof(m_padding), m_padding);
        }
    }
}

