using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMassChangerModifierConstraintAtom Signatire: 0xb6b28240 size: 80 flags: FLAGS_NONE

    // m_factorA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_factorB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpMassChangerModifierConstraintAtom : hkpModifierConstraintAtom
    {
        public Vector4 m_factorA { set; get; } = default;
        public Vector4 m_factorB { set; get; } = default;

        public override uint Signature => 0xb6b28240;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_factorA = br.ReadVector4();
            m_factorB = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_factorA);
            bw.WriteVector4(m_factorB);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_factorA = xd.ReadVector4(xe, nameof(m_factorA));
            m_factorB = xd.ReadVector4(xe, nameof(m_factorB));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_factorA), m_factorA);
            xs.WriteVector4(xe, nameof(m_factorB), m_factorB);
        }
    }
}

