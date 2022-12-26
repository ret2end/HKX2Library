using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLinSoftConstraintAtom Signatire: 0x52b27d69 size: 12 flags: FLAGS_NONE

    // m_axisIndex m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpLinSoftConstraintAtom : hkpConstraintAtom
    {

        public byte m_axisIndex;
        public float m_tau;
        public float m_damping;

        public override uint Signature => 0x52b27d69;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_axisIndex = br.ReadByte();
            br.Position += 1;
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_axisIndex);
            bw.Position += 1;
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

