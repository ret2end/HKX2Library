using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPulleyConstraintAtom Signatire: 0x94a08848 size: 64 flags: FLAGS_NONE

    // m_fixedPivotAinWorld m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_fixedPivotBinWorld m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_ropeLength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_leverageOnBodyB m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    
    public class hkpPulleyConstraintAtom : hkpConstraintAtom
    {

        public Vector4 m_fixedPivotAinWorld;
        public Vector4 m_fixedPivotBinWorld;
        public float m_ropeLength;
        public float m_leverageOnBodyB;

        public override uint Signature => 0x94a08848;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 14;
            m_fixedPivotAinWorld = br.ReadVector4();
            m_fixedPivotBinWorld = br.ReadVector4();
            m_ropeLength = br.ReadSingle();
            m_leverageOnBodyB = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 14;
            bw.WriteVector4(m_fixedPivotAinWorld);
            bw.WriteVector4(m_fixedPivotBinWorld);
            bw.WriteSingle(m_ropeLength);
            bw.WriteSingle(m_leverageOnBodyB);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

