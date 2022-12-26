using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPositionConstraintMotor Signatire: 0x748fb303 size: 48 flags: FLAGS_NONE

    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_proportionalRecoveryVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_constantRecoveryVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    
    public class hkpPositionConstraintMotor : hkpLimitedForceConstraintMotor
    {

        public float m_tau;
        public float m_damping;
        public float m_proportionalRecoveryVelocity;
        public float m_constantRecoveryVelocity;

        public override uint Signature => 0x748fb303;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_proportionalRecoveryVelocity = br.ReadSingle();
            m_constantRecoveryVelocity = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_proportionalRecoveryVelocity);
            bw.WriteSingle(m_constantRecoveryVelocity);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

