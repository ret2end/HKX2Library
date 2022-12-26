using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLinLimitConstraintAtom Signatire: 0xa44d1b07 size: 12 flags: FLAGS_NONE

    // m_axisIndex m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_min m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_max m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpLinLimitConstraintAtom : hkpConstraintAtom
    {

        public byte m_axisIndex;
        public float m_min;
        public float m_max;

        public override uint Signature => 0xa44d1b07;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_axisIndex = br.ReadByte();
            br.Position += 1;
            m_min = br.ReadSingle();
            m_max = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_axisIndex);
            bw.Position += 1;
            bw.WriteSingle(m_min);
            bw.WriteSingle(m_max);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

