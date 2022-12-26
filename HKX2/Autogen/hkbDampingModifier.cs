using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbDampingModifier Signatire: 0x9a040f03 size: 192 flags: FLAGS_NONE

    // m_kP m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_kI m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_kD m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_enableScalarDamping m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_enableVectorDamping m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 93 flags:  enum: 
    // m_rawValue m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_dampedValue m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_rawVector m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_dampedVector m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_vecErrorSum m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_vecPreviousError m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_errorSum m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_previousError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 180 flags:  enum: 
    
    public class hkbDampingModifier : hkbModifier
    {

        public float m_kP;
        public float m_kI;
        public float m_kD;
        public bool m_enableScalarDamping;
        public bool m_enableVectorDamping;
        public float m_rawValue;
        public float m_dampedValue;
        public Vector4 m_rawVector;
        public Vector4 m_dampedVector;
        public Vector4 m_vecErrorSum;
        public Vector4 m_vecPreviousError;
        public float m_errorSum;
        public float m_previousError;

        public override uint Signature => 0x9a040f03;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_kP = br.ReadSingle();
            m_kI = br.ReadSingle();
            m_kD = br.ReadSingle();
            m_enableScalarDamping = br.ReadBoolean();
            m_enableVectorDamping = br.ReadBoolean();
            br.Position += 2;
            m_rawValue = br.ReadSingle();
            m_dampedValue = br.ReadSingle();
            br.Position += 8;
            m_rawVector = br.ReadVector4();
            m_dampedVector = br.ReadVector4();
            m_vecErrorSum = br.ReadVector4();
            m_vecPreviousError = br.ReadVector4();
            m_errorSum = br.ReadSingle();
            m_previousError = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_kP);
            bw.WriteSingle(m_kI);
            bw.WriteSingle(m_kD);
            bw.WriteBoolean(m_enableScalarDamping);
            bw.WriteBoolean(m_enableVectorDamping);
            bw.Position += 2;
            bw.WriteSingle(m_rawValue);
            bw.WriteSingle(m_dampedValue);
            bw.Position += 8;
            bw.WriteVector4(m_rawVector);
            bw.WriteVector4(m_dampedVector);
            bw.WriteVector4(m_vecErrorSum);
            bw.WriteVector4(m_vecPreviousError);
            bw.WriteSingle(m_errorSum);
            bw.WriteSingle(m_previousError);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

