using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLinFrictionConstraintAtom Signatire: 0x3e94ef7c size: 8 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_frictionAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    // m_maxFrictionForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkpLinFrictionConstraintAtom : hkpConstraintAtom
    {

        public byte m_isEnabled;
        public byte m_frictionAxis;
        public float m_maxFrictionForce;

        public override uint Signature => 0x3e94ef7c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_frictionAxis = br.ReadByte();
            m_maxFrictionForce = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_frictionAxis);
            bw.WriteSingle(m_maxFrictionForce);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

