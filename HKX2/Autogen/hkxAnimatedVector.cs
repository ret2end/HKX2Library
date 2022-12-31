using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxAnimatedVector Signatire: 0x34b1a197 size: 40 flags: FLAGS_NONE

    // m_vectors m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_hint m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: Hint
    public partial class hkxAnimatedVector : hkReferencedObject
    {
        public List<Vector4> m_vectors;
        public byte m_hint;

        public override uint Signature => 0x34b1a197;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vectors = des.ReadVector4Array(br);
            m_hint = br.ReadByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4Array(bw, m_vectors);
            s.WriteByte(bw, m_hint);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4Array(xe, nameof(m_vectors), m_vectors);
            xs.WriteEnum<Hint, byte>(xe, nameof(m_hint), m_hint);
        }
    }
}

