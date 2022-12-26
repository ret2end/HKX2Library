using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbPoweredRagdollControlData Signatire: 0xf5ba21b size: 32 flags: FLAGS_NONE

    // m_maxForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_proportionalRecoveryVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_constantRecoveryVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbPoweredRagdollControlData : IHavokObject
    {

        public float m_maxForce;
        public float m_tau;
        public float m_damping;
        public float m_proportionalRecoveryVelocity;
        public float m_constantRecoveryVelocity;

        public uint Signature => 0xf5ba21b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_maxForce = br.ReadSingle();
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_proportionalRecoveryVelocity = br.ReadSingle();
            m_constantRecoveryVelocity = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_maxForce);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_proportionalRecoveryVelocity);
            bw.WriteSingle(m_constantRecoveryVelocity);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

