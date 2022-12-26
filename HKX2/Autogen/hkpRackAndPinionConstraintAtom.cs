using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRackAndPinionConstraintAtom Signatire: 0x30cae006 size: 12 flags: FLAGS_NONE

    // m_pinionRadiusOrScrewPitch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_isScrew m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_memOffsetToInitialAngleOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 9 flags:  enum: 
    // m_memOffsetToPrevAngle m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags:  enum: 
    // m_memOffsetToRevolutionCounter m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 11 flags:  enum: 
    
    public class hkpRackAndPinionConstraintAtom : hkpConstraintAtom
    {

        public float m_pinionRadiusOrScrewPitch;
        public bool m_isScrew;
        public sbyte m_memOffsetToInitialAngleOffset;
        public sbyte m_memOffsetToPrevAngle;
        public sbyte m_memOffsetToRevolutionCounter;

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

            // throw new NotImplementedException("code generated. check first");
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

