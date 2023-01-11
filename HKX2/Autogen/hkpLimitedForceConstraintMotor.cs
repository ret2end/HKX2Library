using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpLimitedForceConstraintMotor Signatire: 0x3377b0b0 size: 32 flags: FLAGS_NONE

    // m_minForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_maxForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    public partial class hkpLimitedForceConstraintMotor : hkpConstraintMotor
    {
        public float m_minForce { set; get; } = default;
        public float m_maxForce { set; get; } = default;

        public override uint Signature => 0x3377b0b0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_minForce = br.ReadSingle();
            m_maxForce = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_minForce);
            bw.WriteSingle(m_maxForce);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_minForce = xd.ReadSingle(xe, nameof(m_minForce));
            m_maxForce = xd.ReadSingle(xe, nameof(m_maxForce));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_minForce), m_minForce);
            xs.WriteFloat(xe, nameof(m_maxForce), m_maxForce);
        }
    }
}

