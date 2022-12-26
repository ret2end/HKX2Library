using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAngFrictionConstraintAtom Signatire: 0xf313aa80 size: 12 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_firstFrictionAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    // m_numFrictionAxes m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_maxFrictionTorque m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpAngFrictionConstraintAtom : hkpConstraintAtom
    {

        public byte m_isEnabled;
        public byte m_firstFrictionAxis;
        public byte m_numFrictionAxes;
        public float m_maxFrictionTorque;

        public override uint Signature => 0xf313aa80;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_firstFrictionAxis = br.ReadByte();
            m_numFrictionAxes = br.ReadByte();
            br.Position += 3;
            m_maxFrictionTorque = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_firstFrictionAxis);
            bw.WriteByte(m_numFrictionAxes);
            bw.Position += 3;
            bw.WriteSingle(m_maxFrictionTorque);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

