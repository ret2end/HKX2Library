using System.Xml.Linq;

namespace HKX2
{
    // hkpShapeCollection Signatire: 0xe8c3991d size: 48 flags: FLAGS_NONE

    // m_disableWelding m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_collectionType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 41 flags: FLAGS_NONE enum: CollectionType
    public partial class hkpShapeCollection : hkpShape
    {
        public bool m_disableWelding;
        public byte m_collectionType;

        public override uint Signature => 0xe8c3991d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_disableWelding = br.ReadBoolean();
            m_collectionType = br.ReadByte();
            br.Position += 6;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteBoolean(m_disableWelding);
            s.WriteByte(bw, m_collectionType);
            bw.Position += 6;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_disableWelding), m_disableWelding);
            xs.WriteEnum<CollectionType, byte>(xe, nameof(m_collectionType), m_collectionType);
        }
    }
}

