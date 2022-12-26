using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSoftContactModifierConstraintAtom Signatire: 0xecb34e27 size: 64 flags: FLAGS_NONE

    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_maxAcceleration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    
    public class hkpSoftContactModifierConstraintAtom : hkpModifierConstraintAtom
    {

        public float m_tau;
        public float m_maxAcceleration;

        public override uint Signature => 0xecb34e27;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_tau = br.ReadSingle();
            m_maxAcceleration = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_maxAcceleration);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

