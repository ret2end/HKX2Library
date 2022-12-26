using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbLookAtModifier Signatire: 0x3d28e066 size: 240 flags: FLAGS_NONE

    // m_targetWS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_headForwardLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_neckForwardLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_neckRightLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_eyePositionHS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_newTargetGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_onGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 164 flags:  enum: 
    // m_offGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_limitAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 172 flags:  enum: 
    // m_limitAngleLeft m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_limitAngleRight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 180 flags:  enum: 
    // m_limitAngleUp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_limitAngleDown m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags:  enum: 
    // m_headIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 192 flags:  enum: 
    // m_neckIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 194 flags:  enum: 
    // m_isOn m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 196 flags:  enum: 
    // m_individualLimitsOn m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 197 flags:  enum: 
    // m_isTargetInsideLimitCone m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 198 flags:  enum: 
    // m_lookAtLastTargetWS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_lookAtWeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbLookAtModifier : hkbModifier
    {

        public Vector4 m_targetWS;
        public Vector4 m_headForwardLS;
        public Vector4 m_neckForwardLS;
        public Vector4 m_neckRightLS;
        public Vector4 m_eyePositionHS;
        public float m_newTargetGain;
        public float m_onGain;
        public float m_offGain;
        public float m_limitAngleDegrees;
        public float m_limitAngleLeft;
        public float m_limitAngleRight;
        public float m_limitAngleUp;
        public float m_limitAngleDown;
        public short m_headIndex;
        public short m_neckIndex;
        public bool m_isOn;
        public bool m_individualLimitsOn;
        public bool m_isTargetInsideLimitCone;
        public Vector4 m_lookAtLastTargetWS;
        public float m_lookAtWeight;

        public override uint Signature => 0x3d28e066;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_targetWS = br.ReadVector4();
            m_headForwardLS = br.ReadVector4();
            m_neckForwardLS = br.ReadVector4();
            m_neckRightLS = br.ReadVector4();
            m_eyePositionHS = br.ReadVector4();
            m_newTargetGain = br.ReadSingle();
            m_onGain = br.ReadSingle();
            m_offGain = br.ReadSingle();
            m_limitAngleDegrees = br.ReadSingle();
            m_limitAngleLeft = br.ReadSingle();
            m_limitAngleRight = br.ReadSingle();
            m_limitAngleUp = br.ReadSingle();
            m_limitAngleDown = br.ReadSingle();
            m_headIndex = br.ReadInt16();
            m_neckIndex = br.ReadInt16();
            m_isOn = br.ReadBoolean();
            m_individualLimitsOn = br.ReadBoolean();
            m_isTargetInsideLimitCone = br.ReadBoolean();
            br.Position += 9;
            m_lookAtLastTargetWS = br.ReadVector4();
            m_lookAtWeight = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_targetWS);
            bw.WriteVector4(m_headForwardLS);
            bw.WriteVector4(m_neckForwardLS);
            bw.WriteVector4(m_neckRightLS);
            bw.WriteVector4(m_eyePositionHS);
            bw.WriteSingle(m_newTargetGain);
            bw.WriteSingle(m_onGain);
            bw.WriteSingle(m_offGain);
            bw.WriteSingle(m_limitAngleDegrees);
            bw.WriteSingle(m_limitAngleLeft);
            bw.WriteSingle(m_limitAngleRight);
            bw.WriteSingle(m_limitAngleUp);
            bw.WriteSingle(m_limitAngleDown);
            bw.WriteInt16(m_headIndex);
            bw.WriteInt16(m_neckIndex);
            bw.WriteBoolean(m_isOn);
            bw.WriteBoolean(m_individualLimitsOn);
            bw.WriteBoolean(m_isTargetInsideLimitCone);
            bw.Position += 9;
            bw.WriteVector4(m_lookAtLastTargetWS);
            bw.WriteSingle(m_lookAtWeight);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

