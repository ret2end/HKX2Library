using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTwistLimitConstraintAtom Signatire: 0x7c9b1052 size: 20 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_twistAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    // m_refAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_minAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_maxAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_angularLimitsTauFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpTwistLimitConstraintAtom : hkpConstraintAtom
    {

        public byte m_isEnabled;
        public byte m_twistAxis;
        public byte m_refAxis;
        public float m_minAngle;
        public float m_maxAngle;
        public float m_angularLimitsTauFactor;

        public override uint Signature => 0x7c9b1052;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_twistAxis = br.ReadByte();
            m_refAxis = br.ReadByte();
            br.Position += 3;
            m_minAngle = br.ReadSingle();
            m_maxAngle = br.ReadSingle();
            m_angularLimitsTauFactor = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_twistAxis);
            bw.WriteByte(m_refAxis);
            bw.Position += 3;
            bw.WriteSingle(m_minAngle);
            bw.WriteSingle(m_maxAngle);
            bw.WriteSingle(m_angularLimitsTauFactor);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

