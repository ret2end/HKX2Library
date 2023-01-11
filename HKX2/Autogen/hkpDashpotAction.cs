using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpDashpotAction Signatire: 0x50746c6e size: 128 flags: FLAGS_NONE

    // m_point m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 2 offset: 64 flags: FLAGS_NONE enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_impulse m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    public partial class hkpDashpotAction : hkpBinaryAction
    {
        public Vector4[] m_point = new Vector4[2];
        public float m_strength { set; get; } = default;
        public float m_damping { set; get; } = default;
        public Vector4 m_impulse { set; get; } = default;

        public override uint Signature => 0x50746c6e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_point = des.ReadVector4CStyleArray(br, 2);
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.Position += 8;
            m_impulse = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4CStyleArray(bw, m_point);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.Position += 8;
            bw.WriteVector4(m_impulse);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_point = xd.ReadVector4CStyleArray(xe, nameof(m_point), 2);
            m_strength = xd.ReadSingle(xe, nameof(m_strength));
            m_damping = xd.ReadSingle(xe, nameof(m_damping));
            m_impulse = xd.ReadVector4(xe, nameof(m_impulse));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4Array(xe, nameof(m_point), m_point);
            xs.WriteFloat(xe, nameof(m_strength), m_strength);
            xs.WriteFloat(xe, nameof(m_damping), m_damping);
            xs.WriteVector4(xe, nameof(m_impulse), m_impulse);
        }
    }
}

