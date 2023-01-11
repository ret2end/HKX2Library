using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpBreakableConstraintData Signatire: 0x7d6310c8 size: 72 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_constraintData m_class: hkpConstraintData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_childRuntimeSize m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_childNumSolverResults m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 58 flags: FLAGS_NONE enum: 
    // m_solverResultLimit m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_removeWhenBroken m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_revertBackVelocityOnBreak m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 65 flags: FLAGS_NONE enum: 
    public partial class hkpBreakableConstraintData : hkpConstraintData
    {
        public hkpBridgeAtoms m_atoms { set; get; } = new();
        public hkpConstraintData? m_constraintData { set; get; } = default;
        public ushort m_childRuntimeSize { set; get; } = default;
        public ushort m_childNumSolverResults { set; get; } = default;
        public float m_solverResultLimit { set; get; } = default;
        public bool m_removeWhenBroken { set; get; } = default;
        public bool m_revertBackVelocityOnBreak { set; get; } = default;

        public override uint Signature => 0x7d6310c8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_atoms.Read(des, br);
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);
            m_childRuntimeSize = br.ReadUInt16();
            m_childNumSolverResults = br.ReadUInt16();
            m_solverResultLimit = br.ReadSingle();
            m_removeWhenBroken = br.ReadBoolean();
            m_revertBackVelocityOnBreak = br.ReadBoolean();
            br.Position += 6;
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_atoms = xd.ReadClass<hkpBridgeAtoms>(xe, nameof(m_atoms));
            m_constraintData = xd.ReadClassPointer<hkpConstraintData>(xe, nameof(m_constraintData));
            m_childRuntimeSize = xd.ReadUInt16(xe, nameof(m_childRuntimeSize));
            m_childNumSolverResults = xd.ReadUInt16(xe, nameof(m_childNumSolverResults));
            m_solverResultLimit = xd.ReadSingle(xe, nameof(m_solverResultLimit));
            m_removeWhenBroken = xd.ReadBoolean(xe, nameof(m_removeWhenBroken));
            m_revertBackVelocityOnBreak = xd.ReadBoolean(xe, nameof(m_revertBackVelocityOnBreak));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpBridgeAtoms>(xe, nameof(m_atoms), m_atoms);
            xs.WriteClassPointer(xe, nameof(m_constraintData), m_constraintData);
            xs.WriteNumber(xe, nameof(m_childRuntimeSize), m_childRuntimeSize);
            xs.WriteNumber(xe, nameof(m_childNumSolverResults), m_childNumSolverResults);
            xs.WriteFloat(xe, nameof(m_solverResultLimit), m_solverResultLimit);
            xs.WriteBoolean(xe, nameof(m_removeWhenBroken), m_removeWhenBroken);
            xs.WriteBoolean(xe, nameof(m_revertBackVelocityOnBreak), m_revertBackVelocityOnBreak);
        }
    }
}

