using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLimitedForceConstraintMotor Signatire: 0x3377b0b0 size: 32 flags: FLAGS_NONE

    // m_minForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_maxForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    
    public class hkpLimitedForceConstraintMotor : hkpConstraintMotor
    {

        public float m_minForce;
        public float m_maxForce;

        public override uint Signature => 0x3377b0b0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_minForce = br.ReadSingle();
            m_maxForce = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_minForce);
            bw.WriteSingle(m_maxForce);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

