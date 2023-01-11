using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpConstrainedSystemFilter Signatire: 0x20a447fe size: 88 flags: FLAGS_NONE

    // m_otherFilter m_class: hkpCollisionFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkpConstrainedSystemFilter : hkpCollisionFilter
    {
        public hkpCollisionFilter? m_otherFilter { set; get; } = default;

        public override uint Signature => 0x20a447fe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_otherFilter = des.ReadClassPointer<hkpCollisionFilter>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_otherFilter);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_otherFilter = xd.ReadClassPointer<hkpCollisionFilter>(xe, nameof(m_otherFilter));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_otherFilter), m_otherFilter);
        }
    }
}

