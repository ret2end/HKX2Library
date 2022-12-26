using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbHandIkDriverInfoHand Signatire: 0x14dfe1dd size: 96 flags: FLAGS_NONE

    // m_elbowAxisLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_backHandNormalLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_handOffsetLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_handOrienationOffsetLS m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_maxElbowAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_minElbowAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_shoulderIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_shoulderSiblingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 74 flags:  enum: 
    // m_elbowIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 
    // m_elbowSiblingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 78 flags:  enum: 
    // m_wristIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_enforceEndPosition m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 82 flags:  enum: 
    // m_enforceEndRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 83 flags:  enum: 
    // m_localFrameName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    
    public class hkbHandIkDriverInfoHand : IHavokObject
    {

        public Vector4 m_elbowAxisLS;
        public Vector4 m_backHandNormalLS;
        public Vector4 m_handOffsetLS;
        public Quaternion m_handOrienationOffsetLS;
        public float m_maxElbowAngleDegrees;
        public float m_minElbowAngleDegrees;
        public short m_shoulderIndex;
        public short m_shoulderSiblingIndex;
        public short m_elbowIndex;
        public short m_elbowSiblingIndex;
        public short m_wristIndex;
        public bool m_enforceEndPosition;
        public bool m_enforceEndRotation;
        public string m_localFrameName;

        public uint Signature => 0x14dfe1dd;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
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

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

