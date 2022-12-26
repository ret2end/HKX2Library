using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAngLimitConstraintAtom Signatire: 0x9be0d9d size: 16 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_limitAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    // m_minAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_maxAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_angularLimitsTauFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkpAngLimitConstraintAtom : hkpConstraintAtom
    {

        public byte m_isEnabled;
        public byte m_limitAxis;
        public float m_minAngle;
        public float m_maxAngle;
        public float m_angularLimitsTauFactor;

        public override uint Signature => 0x9be0d9d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_limitAxis = br.ReadByte();
            m_minAngle = br.ReadSingle();
            m_maxAngle = br.ReadSingle();
            m_angularLimitsTauFactor = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_limitAxis);
            bw.WriteSingle(m_minAngle);
            bw.WriteSingle(m_maxAngle);
            bw.WriteSingle(m_angularLimitsTauFactor);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

