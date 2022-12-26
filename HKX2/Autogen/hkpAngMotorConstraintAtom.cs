using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAngMotorConstraintAtom Signatire: 0x81f087ff size: 24 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_motorAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    // m_initializedOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_previousTargetAngleOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 6 flags:  enum: 
    // m_correspondingAngLimitSolverResultOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_targetAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_motor m_class: hkpConstraintMotor Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpAngMotorConstraintAtom : hkpConstraintAtom
    {

        public bool m_isEnabled;
        public byte m_motorAxis;
        public short m_initializedOffset;
        public short m_previousTargetAngleOffset;
        public short m_correspondingAngLimitSolverResultOffset;
        public float m_targetAngle;
        public hkpConstraintMotor /*pointer struct*/ m_motor;

        public override uint Signature => 0x81f087ff;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isEnabled = br.ReadBoolean();
            m_motorAxis = br.ReadByte();
            m_initializedOffset = br.ReadInt16();
            m_previousTargetAngleOffset = br.ReadInt16();
            m_correspondingAngLimitSolverResultOffset = br.ReadInt16();
            br.Position += 2;
            m_targetAngle = br.ReadSingle();
            m_motor = des.ReadClassPointer<hkpConstraintMotor>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_isEnabled);
            bw.WriteByte(m_motorAxis);
            bw.WriteInt16(m_initializedOffset);
            bw.WriteInt16(m_previousTargetAngleOffset);
            bw.WriteInt16(m_correspondingAngLimitSolverResultOffset);
            bw.Position += 2;
            bw.WriteSingle(m_targetAngle);
            s.WriteClassPointer(bw, m_motor);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

