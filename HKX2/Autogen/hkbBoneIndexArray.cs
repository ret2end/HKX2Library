using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBoneIndexArray Signatire: 0xaa8619 size: 64 flags: FLAGS_NONE

    // m_boneIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkbBoneIndexArray : hkbBindable
    {
        public List<short> m_boneIndices;

        public override uint Signature => 0xaa8619;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_boneIndices = des.ReadInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt16Array(bw, m_boneIndices);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_boneIndices = xd.ReadInt16Array(xe, nameof(m_boneIndices));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_boneIndices), m_boneIndices);
        }
    }
}

