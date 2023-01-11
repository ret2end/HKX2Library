using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpRackAndPinionConstraintAtom Signatire: 0x30cae006 size: 12 flags: FLAGS_NONE

    // m_pinionRadiusOrScrewPitch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_isScrew m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_memOffsetToInitialAngleOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 9 flags: FLAGS_NONE enum: 
    // m_memOffsetToPrevAngle m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags: FLAGS_NONE enum: 
    // m_memOffsetToRevolutionCounter m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 11 flags: FLAGS_NONE enum: 
    public partial class hkpRackAndPinionConstraintAtom : hkpConstraintAtom
    {
        public float m_pinionRadiusOrScrewPitch { set; get; } = default;
        public bool m_isScrew { set; get; } = default;
        public sbyte m_memOffsetToInitialAngleOffset { set; get; } = default;
        public sbyte m_memOffsetToPrevAngle { set; get; } = default;
        public sbyte m_memOffsetToRevolutionCounter { set; get; } = default;

        public override uint Signature => 0x30cae006;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 2;
            m_pinionRadiusOrScrewPitch = br.ReadSingle();
            m_isScrew = br.ReadBoolean();
            m_memOffsetToInitialAngleOffset = br.ReadSByte();
            m_memOffsetToPrevAngle = br.ReadSByte();
            m_memOffsetToRevolutionCounter = br.ReadSByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 2;
            bw.WriteSingle(m_pinionRadiusOrScrewPitch);
            bw.WriteBoolean(m_isScrew);
            bw.WriteSByte(m_memOffsetToInitialAngleOffset);
            bw.WriteSByte(m_memOffsetToPrevAngle);
            bw.WriteSByte(m_memOffsetToRevolutionCounter);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_pinionRadiusOrScrewPitch = xd.ReadSingle(xe, nameof(m_pinionRadiusOrScrewPitch));
            m_isScrew = xd.ReadBoolean(xe, nameof(m_isScrew));
            m_memOffsetToInitialAngleOffset = xd.ReadSByte(xe, nameof(m_memOffsetToInitialAngleOffset));
            m_memOffsetToPrevAngle = xd.ReadSByte(xe, nameof(m_memOffsetToPrevAngle));
            m_memOffsetToRevolutionCounter = xd.ReadSByte(xe, nameof(m_memOffsetToRevolutionCounter));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_pinionRadiusOrScrewPitch), m_pinionRadiusOrScrewPitch);
            xs.WriteBoolean(xe, nameof(m_isScrew), m_isScrew);
            xs.WriteNumber(xe, nameof(m_memOffsetToInitialAngleOffset), m_memOffsetToInitialAngleOffset);
            xs.WriteNumber(xe, nameof(m_memOffsetToPrevAngle), m_memOffsetToPrevAngle);
            xs.WriteNumber(xe, nameof(m_memOffsetToRevolutionCounter), m_memOffsetToRevolutionCounter);
        }
    }
}

