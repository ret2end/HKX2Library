using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxAnimatedFloat Signatire: 0xce8b2fbd size: 40 flags: FLAGS_NONE

    // m_floats m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_hint m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: Hint
    public partial class hkxAnimatedFloat : hkReferencedObject
    {
        public List<float> m_floats;
        public byte m_hint;

        public override uint Signature => 0xce8b2fbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_floats = des.ReadSingleArray(br);
            m_hint = br.ReadByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_floats);
            s.WriteByte(bw, m_hint);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_floats = xd.ReadSingleArray(xe, nameof(m_floats));
            m_hint = xd.ReadFlag<Hint, byte>(xe, nameof(m_hint));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloatArray(xe, nameof(m_floats), m_floats);
            xs.WriteEnum<Hint, byte>(xe, nameof(m_hint), m_hint);
        }
    }
}

