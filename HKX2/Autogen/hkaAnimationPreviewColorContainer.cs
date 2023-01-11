using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkaAnimationPreviewColorContainer Signatire: 0x4bc4c3e0 size: 32 flags: FLAGS_NONE

    // m_previewColor m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkaAnimationPreviewColorContainer : hkReferencedObject
    {
        public IList<uint> m_previewColor { set; get; } = new List<uint>();

        public override uint Signature => 0x4bc4c3e0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_previewColor = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_previewColor);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_previewColor = xd.ReadUInt32Array(xe, nameof(m_previewColor));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_previewColor), m_previewColor);
        }
    }
}

