using System.Xml.Linq;

namespace HKX2
{
    // hkbEventRaisedInfo Signatire: 0xc02da3 size: 48 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_eventName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_raisedBySdk m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_senderId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_padding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    public partial class hkbEventRaisedInfo : hkReferencedObject
    {
        public ulong m_characterId;
        public string m_eventName;
        public bool m_raisedBySdk;
        public int m_senderId;
        public int m_padding;

        public override uint Signature => 0xc02da3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_eventName = des.ReadStringPointer(br);
            m_raisedBySdk = br.ReadBoolean();
            br.Position += 3;
            m_senderId = br.ReadInt32();
            m_padding = br.ReadInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteStringPointer(bw, m_eventName);
            bw.WriteBoolean(m_raisedBySdk);
            bw.Position += 3;
            bw.WriteInt32(m_senderId);
            bw.WriteInt32(m_padding);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteString(xe, nameof(m_eventName), m_eventName);
            xs.WriteBoolean(xe, nameof(m_raisedBySdk), m_raisedBySdk);
            xs.WriteNumber(xe, nameof(m_senderId), m_senderId);
            xs.WriteNumber(xe, nameof(m_padding), m_padding);
        }
    }
}

