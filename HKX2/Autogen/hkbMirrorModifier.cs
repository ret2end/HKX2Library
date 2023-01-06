using System.Xml.Linq;

namespace HKX2
{
    // hkbMirrorModifier Signatire: 0xa9a271ea size: 88 flags: FLAGS_NONE

    // m_isAdditive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkbMirrorModifier : hkbModifier
    {
        public bool m_isAdditive;

        public override uint Signature => 0xa9a271ea;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isAdditive = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_isAdditive);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_isAdditive = xd.ReadBoolean(xe, nameof(m_isAdditive));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_isAdditive), m_isAdditive);
        }
    }
}

