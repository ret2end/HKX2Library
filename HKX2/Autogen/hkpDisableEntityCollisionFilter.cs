using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpDisableEntityCollisionFilter Signatire: 0xfac3351c size: 96 flags: FLAGS_NONE

    // m_disabledEntities m_class: hkpEntity Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkpDisableEntityCollisionFilter : hkpCollisionFilter
    {
        public IList<hkpEntity> m_disabledEntities { set; get; } = new List<hkpEntity>();

        public override uint Signature => 0xfac3351c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_disabledEntities = des.ReadClassPointerArray<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointerArray(bw, m_disabledEntities);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_disabledEntities = xd.ReadClassPointerArray<hkpEntity>(xe, nameof(m_disabledEntities));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpEntity>(xe, nameof(m_disabledEntities), m_disabledEntities);
        }
    }
}

