using System.Xml.Linq;

namespace HKX2
{
    // hkpBinaryAction Signatire: 0xc00f3403 size: 64 flags: FLAGS_NONE

    // m_entityA m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_entityB m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    public partial class hkpBinaryAction : hkpAction
    {
        public hkpEntity m_entityA;
        public hkpEntity m_entityB;

        public override uint Signature => 0xc00f3403;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_entityA = des.ReadClassPointer<hkpEntity>(br);
            m_entityB = des.ReadClassPointer<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_entityA);
            s.WriteClassPointer(bw, m_entityB);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_entityA = xd.ReadClassPointer<hkpEntity>(xe, nameof(m_entityA));
            m_entityB = xd.ReadClassPointer<hkpEntity>(xe, nameof(m_entityB));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_entityA), m_entityA);
            xs.WriteClassPointer(xe, nameof(m_entityB), m_entityB);
        }
    }
}

