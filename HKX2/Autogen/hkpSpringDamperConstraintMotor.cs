using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSpringDamperConstraintMotor Signatire: 0x7ead26f6 size: 40 flags: FLAGS_NONE

    // m_springConstant m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_springDamping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    
    public class hkpSpringDamperConstraintMotor : hkpLimitedForceConstraintMotor
    {

        public float m_springConstant;
        public float m_springDamping;

        public override uint Signature => 0x7ead26f6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_springConstant = br.ReadSingle();
            m_springDamping = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_springConstant);
            bw.WriteSingle(m_springDamping);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

