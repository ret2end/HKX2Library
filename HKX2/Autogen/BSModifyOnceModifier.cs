using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSModifyOnceModifier Signatire: 0x1e20a97a size: 112 flags: FLAGS_NONE

    // m_pOnActivateModifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_pOnDeactivateModifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class BSModifyOnceModifier : hkbModifier
    {
        public hkbModifier? m_pOnActivateModifier { set; get; } = default;
        public hkbModifier? m_pOnDeactivateModifier { set; get; } = default;

        public override uint Signature => 0x1e20a97a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_pOnActivateModifier = des.ReadClassPointer<hkbModifier>(br);
            br.Position += 8;
            m_pOnDeactivateModifier = des.ReadClassPointer<hkbModifier>(br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_pOnActivateModifier);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pOnDeactivateModifier);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_pOnActivateModifier = xd.ReadClassPointer<hkbModifier>(xe, nameof(m_pOnActivateModifier));
            m_pOnDeactivateModifier = xd.ReadClassPointer<hkbModifier>(xe, nameof(m_pOnDeactivateModifier));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_pOnActivateModifier), m_pOnActivateModifier);
            xs.WriteClassPointer(xe, nameof(m_pOnDeactivateModifier), m_pOnDeactivateModifier);
        }
    }
}

