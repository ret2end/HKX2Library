using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbHandIkModifierHand Signatire: 0x14dfe1dd size: 96 flags: FLAGS_NONE

    // m_elbowAxisLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_backHandNormalLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_handOffsetLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_handOrienationOffsetLS m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_maxElbowAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_minElbowAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_shoulderIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_shoulderSiblingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 74 flags: FLAGS_NONE enum: 
    // m_elbowIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 76 flags: FLAGS_NONE enum: 
    // m_elbowSiblingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 78 flags: FLAGS_NONE enum: 
    // m_wristIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_enforceEndPosition m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 82 flags: FLAGS_NONE enum: 
    // m_enforceEndRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 83 flags: FLAGS_NONE enum: 
    // m_localFrameName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    public partial class hkbHandIkModifierHand : IHavokObject
    {
        public Vector4 m_elbowAxisLS { set; get; } = default;
        public Vector4 m_backHandNormalLS { set; get; } = default;
        public Vector4 m_handOffsetLS { set; get; } = default;
        public Quaternion m_handOrienationOffsetLS { set; get; } = default;
        public float m_maxElbowAngleDegrees { set; get; } = default;
        public float m_minElbowAngleDegrees { set; get; } = default;
        public short m_shoulderIndex { set; get; } = default;
        public short m_shoulderSiblingIndex { set; get; } = default;
        public short m_elbowIndex { set; get; } = default;
        public short m_elbowSiblingIndex { set; get; } = default;
        public short m_wristIndex { set; get; } = default;
        public bool m_enforceEndPosition { set; get; } = default;
        public bool m_enforceEndRotation { set; get; } = default;
        public string m_localFrameName { set; get; } = "";

        public virtual uint Signature => 0x14dfe1dd;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_elbowAxisLS = br.ReadVector4();
            m_backHandNormalLS = br.ReadVector4();
            m_handOffsetLS = br.ReadVector4();
            m_handOrienationOffsetLS = des.ReadQuaternion(br);
            m_maxElbowAngleDegrees = br.ReadSingle();
            m_minElbowAngleDegrees = br.ReadSingle();
            m_shoulderIndex = br.ReadInt16();
            m_shoulderSiblingIndex = br.ReadInt16();
            m_elbowIndex = br.ReadInt16();
            m_elbowSiblingIndex = br.ReadInt16();
            m_wristIndex = br.ReadInt16();
            m_enforceEndPosition = br.ReadBoolean();
            m_enforceEndRotation = br.ReadBoolean();
            br.Position += 4;
            m_localFrameName = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_elbowAxisLS);
            bw.WriteVector4(m_backHandNormalLS);
            bw.WriteVector4(m_handOffsetLS);
            s.WriteQuaternion(bw, m_handOrienationOffsetLS);
            bw.WriteSingle(m_maxElbowAngleDegrees);
            bw.WriteSingle(m_minElbowAngleDegrees);
            bw.WriteInt16(m_shoulderIndex);
            bw.WriteInt16(m_shoulderSiblingIndex);
            bw.WriteInt16(m_elbowIndex);
            bw.WriteInt16(m_elbowSiblingIndex);
            bw.WriteInt16(m_wristIndex);
            bw.WriteBoolean(m_enforceEndPosition);
            bw.WriteBoolean(m_enforceEndRotation);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_localFrameName);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_elbowAxisLS = xd.ReadVector4(xe, nameof(m_elbowAxisLS));
            m_backHandNormalLS = xd.ReadVector4(xe, nameof(m_backHandNormalLS));
            m_handOffsetLS = xd.ReadVector4(xe, nameof(m_handOffsetLS));
            m_handOrienationOffsetLS = xd.ReadQuaternion(xe, nameof(m_handOrienationOffsetLS));
            m_maxElbowAngleDegrees = xd.ReadSingle(xe, nameof(m_maxElbowAngleDegrees));
            m_minElbowAngleDegrees = xd.ReadSingle(xe, nameof(m_minElbowAngleDegrees));
            m_shoulderIndex = xd.ReadInt16(xe, nameof(m_shoulderIndex));
            m_shoulderSiblingIndex = xd.ReadInt16(xe, nameof(m_shoulderSiblingIndex));
            m_elbowIndex = xd.ReadInt16(xe, nameof(m_elbowIndex));
            m_elbowSiblingIndex = xd.ReadInt16(xe, nameof(m_elbowSiblingIndex));
            m_wristIndex = xd.ReadInt16(xe, nameof(m_wristIndex));
            m_enforceEndPosition = xd.ReadBoolean(xe, nameof(m_enforceEndPosition));
            m_enforceEndRotation = xd.ReadBoolean(xe, nameof(m_enforceEndRotation));
            m_localFrameName = xd.ReadString(xe, nameof(m_localFrameName));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_elbowAxisLS), m_elbowAxisLS);
            xs.WriteVector4(xe, nameof(m_backHandNormalLS), m_backHandNormalLS);
            xs.WriteVector4(xe, nameof(m_handOffsetLS), m_handOffsetLS);
            xs.WriteQuaternion(xe, nameof(m_handOrienationOffsetLS), m_handOrienationOffsetLS);
            xs.WriteFloat(xe, nameof(m_maxElbowAngleDegrees), m_maxElbowAngleDegrees);
            xs.WriteFloat(xe, nameof(m_minElbowAngleDegrees), m_minElbowAngleDegrees);
            xs.WriteNumber(xe, nameof(m_shoulderIndex), m_shoulderIndex);
            xs.WriteNumber(xe, nameof(m_shoulderSiblingIndex), m_shoulderSiblingIndex);
            xs.WriteNumber(xe, nameof(m_elbowIndex), m_elbowIndex);
            xs.WriteNumber(xe, nameof(m_elbowSiblingIndex), m_elbowSiblingIndex);
            xs.WriteNumber(xe, nameof(m_wristIndex), m_wristIndex);
            xs.WriteBoolean(xe, nameof(m_enforceEndPosition), m_enforceEndPosition);
            xs.WriteBoolean(xe, nameof(m_enforceEndRotation), m_enforceEndRotation);
            xs.WriteString(xe, nameof(m_localFrameName), m_localFrameName);
        }
    }
}

