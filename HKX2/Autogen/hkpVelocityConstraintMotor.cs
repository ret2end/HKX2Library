using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpVelocityConstraintMotor Signatire: 0xfca2fcc3 size: 48 flags: FLAGS_NONE

    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_velocityTarget m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_useVelocityTargetFromConstraintTargets m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkpVelocityConstraintMotor : hkpLimitedForceConstraintMotor
    {

        public float m_tau;
        public float m_velocityTarget;
        public bool m_useVelocityTargetFromConstraintTargets;

        public override uint Signature => 0xfca2fcc3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_tau = br.ReadSingle();
            m_velocityTarget = br.ReadSingle();
            m_useVelocityTargetFromConstraintTargets = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_velocityTarget);
            bw.WriteBoolean(m_useVelocityTargetFromConstraintTargets);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

