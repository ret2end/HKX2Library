using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSerializedDisplayRbTransforms Signatire: 0xc18650ac size: 32 flags: FLAGS_NONE

    // m_transforms m_class: hkpSerializedDisplayRbTransformsDisplayTransformPair Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkpSerializedDisplayRbTransforms : hkReferencedObject
    {
        public IList<hkpSerializedDisplayRbTransformsDisplayTransformPair> m_transforms { set; get; } = new List<hkpSerializedDisplayRbTransformsDisplayTransformPair>();

        public override uint Signature => 0xc18650ac;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transforms = des.ReadClassArray<hkpSerializedDisplayRbTransformsDisplayTransformPair>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_transforms);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_transforms = xd.ReadClassArray<hkpSerializedDisplayRbTransformsDisplayTransformPair>(xe, nameof(m_transforms));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkpSerializedDisplayRbTransformsDisplayTransformPair>(xe, nameof(m_transforms), m_transforms);
        }
    }
}

