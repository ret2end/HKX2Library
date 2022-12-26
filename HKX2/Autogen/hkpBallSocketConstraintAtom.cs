using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBallSocketConstraintAtom Signatire: 0xe70e4dfa size: 16 flags: FLAGS_NONE

    // m_solvingMethod m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 2 flags:  enum: SolvingMethod
    // m_bodiesToNotify m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    // m_velocityStabilizationFactor m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_maxImpulse m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_inertiaStabilizationFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkpBallSocketConstraintAtom : hkpConstraintAtom
    {

        public byte m_solvingMethod;
        public byte m_bodiesToNotify;
        public byte m_velocityStabilizationFactor;
        public float m_maxImpulse;
        public float m_inertiaStabilizationFactor;

        public override uint Signature => 0xe70e4dfa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_solvingMethod = br.ReadByte();
            m_bodiesToNotify = br.ReadByte();
            m_velocityStabilizationFactor = br.ReadByte();
            br.Position += 3;
            m_maxImpulse = br.ReadSingle();
            m_inertiaStabilizationFactor = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_solvingMethod);
            bw.WriteByte(m_bodiesToNotify);
            bw.WriteByte(m_velocityStabilizationFactor);
            bw.Position += 3;
            bw.WriteSingle(m_maxImpulse);
            bw.WriteSingle(m_inertiaStabilizationFactor);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

