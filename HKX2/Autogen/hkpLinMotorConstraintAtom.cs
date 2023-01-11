using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpLinMotorConstraintAtom Signatire: 0x10312464 size: 24 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_motorAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags: FLAGS_NONE enum: 
    // m_initializedOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_previousTargetPositionOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 6 flags: FLAGS_NONE enum: 
    // m_targetPosition m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_motor m_class: hkpConstraintMotor Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkpLinMotorConstraintAtom : hkpConstraintAtom
    {
        public bool m_isEnabled { set; get; } = default;
        public byte m_motorAxis { set; get; } = default;
        public short m_initializedOffset { set; get; } = default;
        public short m_previousTargetPositionOffset { set; get; } = default;
        public float m_targetPosition { set; get; } = default;
        public hkpConstraintMotor? m_motor { set; get; } = default;

        public override uint Signature => 0x10312464;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadBoolean();
            m_motorAxis = br.ReadByte();
            m_initializedOffset = br.ReadInt16();
            m_previousTargetPositionOffset = br.ReadInt16();
            m_targetPosition = br.ReadSingle();
            br.Position += 4;
            m_motor = des.ReadClassPointer<hkpConstraintMotor>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_isEnabled);
            bw.WriteByte(m_motorAxis);
            bw.WriteInt16(m_initializedOffset);
            bw.WriteInt16(m_previousTargetPositionOffset);
            bw.WriteSingle(m_targetPosition);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_motor);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_isEnabled = xd.ReadBoolean(xe, nameof(m_isEnabled));
            m_motorAxis = xd.ReadByte(xe, nameof(m_motorAxis));
            m_initializedOffset = xd.ReadInt16(xe, nameof(m_initializedOffset));
            m_previousTargetPositionOffset = xd.ReadInt16(xe, nameof(m_previousTargetPositionOffset));
            m_targetPosition = xd.ReadSingle(xe, nameof(m_targetPosition));
            m_motor = xd.ReadClassPointer<hkpConstraintMotor>(xe, nameof(m_motor));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_isEnabled), m_isEnabled);
            xs.WriteNumber(xe, nameof(m_motorAxis), m_motorAxis);
            xs.WriteNumber(xe, nameof(m_initializedOffset), m_initializedOffset);
            xs.WriteNumber(xe, nameof(m_previousTargetPositionOffset), m_previousTargetPositionOffset);
            xs.WriteFloat(xe, nameof(m_targetPosition), m_targetPosition);
            xs.WriteClassPointer(xe, nameof(m_motor), m_motor);
        }
    }
}

