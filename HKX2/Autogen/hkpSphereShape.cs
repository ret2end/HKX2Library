using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSphereShape Signatire: 0x795d9fa size: 56 flags: FLAGS_NONE

    // m_pad16 m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 40 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpSphereShape : hkpConvexShape
    {
        public List<uint> m_pad16;

        public override uint Signature => 0x795d9fa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_pad16 = des.ReadUInt32CStyleArray(br, 3);
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32CStyleArray(bw, m_pad16);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_pad16));
        }
    }
}

