using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbDampingModifierInternalState Signatire: 0x508d3b36 size: 80 flags: FLAGS_NONE

    // m_dampedVector m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_vecErrorSum m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_vecPreviousError m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_dampedValue m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_errorSum m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_previousError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    
    public class hkbDampingModifierInternalState : hkReferencedObject
    {

        public Vector4 m_dampedVector;
        public Vector4 m_vecErrorSum;
        public Vector4 m_vecPreviousError;
        public float m_dampedValue;
        public float m_errorSum;
        public float m_previousError;

        public override uint Signature => 0x508d3b36;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_dampedVector = br.ReadVector4();
            m_vecErrorSum = br.ReadVector4();
            m_vecPreviousError = br.ReadVector4();
            m_dampedValue = br.ReadSingle();
            m_errorSum = br.ReadSingle();
            m_previousError = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_dampedVector);
            bw.WriteVector4(m_vecErrorSum);
            bw.WriteVector4(m_vecPreviousError);
            bw.WriteSingle(m_dampedValue);
            bw.WriteSingle(m_errorSum);
            bw.WriteSingle(m_previousError);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

