using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpBallSocketConstraintAtom Signatire: 0xe70e4dfa size: 16 flags: FLAGS_NONE

    // m_solvingMethod m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 2 flags: FLAGS_NONE enum: SolvingMethod
    // m_bodiesToNotify m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags: FLAGS_NONE enum: 
    // m_velocityStabilizationFactor m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_maxImpulse m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_inertiaStabilizationFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkpBallSocketConstraintAtom : hkpConstraintAtom
    {
        public byte m_solvingMethod { set; get; } = default;
        public byte m_bodiesToNotify { set; get; } = default;
        public byte m_velocityStabilizationFactor { set; get; } = default;
        public float m_maxImpulse { set; get; } = default;
        public float m_inertiaStabilizationFactor { set; get; } = default;

        public override uint Signature => 0xe70e4dfa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_solvingMethod = br.ReadByte();
            m_bodiesToNotify = br.ReadByte();
            m_velocityStabilizationFactor = br.ReadByte();
            br.Position += 3;
            m_maxImpulse = br.ReadSingle();
            m_inertiaStabilizationFactor = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_solvingMethod);
            bw.WriteByte(m_bodiesToNotify);
            bw.WriteByte(m_velocityStabilizationFactor);
            bw.Position += 3;
            bw.WriteSingle(m_maxImpulse);
            bw.WriteSingle(m_inertiaStabilizationFactor);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_solvingMethod = xd.ReadFlag<SolvingMethod, byte>(xe, nameof(m_solvingMethod));
            m_bodiesToNotify = xd.ReadByte(xe, nameof(m_bodiesToNotify));
            m_velocityStabilizationFactor = xd.ReadByte(xe, nameof(m_velocityStabilizationFactor));
            m_maxImpulse = xd.ReadSingle(xe, nameof(m_maxImpulse));
            m_inertiaStabilizationFactor = xd.ReadSingle(xe, nameof(m_inertiaStabilizationFactor));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<SolvingMethod, byte>(xe, nameof(m_solvingMethod), m_solvingMethod);
            xs.WriteNumber(xe, nameof(m_bodiesToNotify), m_bodiesToNotify);
            xs.WriteNumber(xe, nameof(m_velocityStabilizationFactor), m_velocityStabilizationFactor);
            xs.WriteFloat(xe, nameof(m_maxImpulse), m_maxImpulse);
            xs.WriteFloat(xe, nameof(m_inertiaStabilizationFactor), m_inertiaStabilizationFactor);
        }
    }
}

