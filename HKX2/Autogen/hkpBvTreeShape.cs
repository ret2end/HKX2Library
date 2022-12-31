using System.Xml.Linq;

namespace HKX2
{
    // hkpBvTreeShape Signatire: 0xa823d623 size: 40 flags: FLAGS_NONE

    // m_bvTreeType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: BvTreeType
    public partial class hkpBvTreeShape : hkpShape
    {
        public byte m_bvTreeType;

        public override uint Signature => 0xa823d623;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bvTreeType = br.ReadByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteByte(bw, m_bvTreeType);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<BvTreeType, byte>(xe, nameof(m_bvTreeType), m_bvTreeType);
        }
    }
}

