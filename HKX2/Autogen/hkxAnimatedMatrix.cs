using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxAnimatedMatrix Signatire: 0x5838e337 size: 40 flags: FLAGS_NONE

    // m_matrices m_class:  Type.TYPE_ARRAY Type.TYPE_MATRIX4 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_hint m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: Hint
    public partial class hkxAnimatedMatrix : hkReferencedObject
    {
        public IList<Matrix4x4> m_matrices { set; get; } = new List<Matrix4x4>();
        public byte m_hint { set; get; } = default;

        public override uint Signature => 0x5838e337;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_matrices = des.ReadMatrix4Array(br);
            m_hint = br.ReadByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteMatrix4Array(bw, m_matrices);
            bw.WriteByte(m_hint);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_matrices = xd.ReadMatrix4Array(xe, nameof(m_matrices));
            m_hint = xd.ReadFlag<Hint, byte>(xe, nameof(m_hint));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteMatrix4Array(xe, nameof(m_matrices), m_matrices);
            xs.WriteEnum<Hint, byte>(xe, nameof(m_hint), m_hint);
        }
    }
}

