using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpArrayAction Signatire: 0x674bcd2d size: 64 flags: FLAGS_NONE

    // m_entities m_class: hkpEntity Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpArrayAction : hkpAction
    {
        public List<hkpEntity> m_entities = new List<hkpEntity>();

        public override uint Signature => 0x674bcd2d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_entities = des.ReadClassPointerArray<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkpEntity>(bw, m_entities);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_entities = xd.ReadClassPointerArray<hkpEntity>(xe, nameof(m_entities));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpEntity>(xe, nameof(m_entities), m_entities);
        }
    }
}

