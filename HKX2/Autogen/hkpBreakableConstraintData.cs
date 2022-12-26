using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBreakableConstraintData Signatire: 0x7d6310c8 size: 72 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_constraintData m_class: hkpConstraintData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_childRuntimeSize m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_childNumSolverResults m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 58 flags:  enum: 
    // m_solverResultLimit m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_removeWhenBroken m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_revertBackVelocityOnBreak m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 65 flags:  enum: 
    
    public class hkpBreakableConstraintData : hkpConstraintData
    {

        public hkpBridgeAtoms/*struct void*/ m_atoms;
        public hkpConstraintData /*pointer struct*/ m_constraintData;
        public ushort m_childRuntimeSize;
        public ushort m_childNumSolverResults;
        public float m_solverResultLimit;
        public bool m_removeWhenBroken;
        public bool m_revertBackVelocityOnBreak;

        public override uint Signature => 0x7d6310c8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des,br);
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);
            m_childRuntimeSize = br.ReadUInt16();
            m_childNumSolverResults = br.ReadUInt16();
            m_solverResultLimit = br.ReadSingle();
            m_removeWhenBroken = br.ReadBoolean();
            m_revertBackVelocityOnBreak = br.ReadBoolean();
            br.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_atoms.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintData);
            bw.WriteUInt16(m_childRuntimeSize);
            bw.WriteUInt16(m_childNumSolverResults);
            bw.WriteSingle(m_solverResultLimit);
            bw.WriteBoolean(m_removeWhenBroken);
            bw.WriteBoolean(m_revertBackVelocityOnBreak);
            bw.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

