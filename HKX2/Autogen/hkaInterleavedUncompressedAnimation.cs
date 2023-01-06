using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkaInterleavedUncompressedAnimation Signatire: 0x930af031 size: 88 flags: FLAGS_NONE

    // m_transforms m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_floats m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    public partial class hkaInterleavedUncompressedAnimation : hkaAnimation
    {
        public List<Matrix4x4> m_transforms;
        public List<float> m_floats;

        public override uint Signature => 0x930af031;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transforms = des.ReadQSTransformArray(br);
            m_floats = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteQSTransformArray(bw, m_transforms);
            s.WriteSingleArray(bw, m_floats);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_transforms = xd.ReadQSTransformArray(xe, nameof(m_transforms));
            m_floats = xd.ReadSingleArray(xe, nameof(m_floats));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteQSTransformArray(xe, nameof(m_transforms), m_transforms);
            xs.WriteFloatArray(xe, nameof(m_floats), m_floats);
        }
    }
}

