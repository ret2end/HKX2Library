using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxSparselyAnimatedEnum Signatire: 0x68a47b64 size: 56 flags: FLAGS_NONE

    // m_enum m_class: hkxEnum Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkxSparselyAnimatedEnum : hkxSparselyAnimatedInt
    {
        public hkxEnum? m_enum { set; get; } = default;

        public override uint Signature => 0x68a47b64;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_enum = des.ReadClassPointer<hkxEnum>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_enum);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_enum = xd.ReadClassPointer<hkxEnum>(xe, nameof(m_enum));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_enum), m_enum);
        }
    }
}

