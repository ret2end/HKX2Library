using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSenseHandleModifier Signatire: 0x2a064d99 size: 224 flags: FLAGS_NONE

    // m_handle m_class: hkbHandle Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_sensorLocalOffset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_ranges m_class: hkbSenseHandleModifierRange Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 144 flags:  enum: 
    // m_handleOut m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 160 flags:  enum: 
    // m_handleIn m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 168 flags:  enum: 
    // m_localFrameName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_sensorLocalFrameName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_minDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 192 flags:  enum: 
    // m_maxDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 196 flags:  enum: 
    // m_distanceOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 200 flags:  enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 204 flags:  enum: 
    // m_sensorRagdollBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 208 flags:  enum: 
    // m_sensorAnimationBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 210 flags:  enum: 
    // m_sensingMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 212 flags:  enum: SensingMode
    // m_extrapolateSensorPosition m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 213 flags:  enum: 
    // m_keepFirstSensedHandle m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 214 flags:  enum: 
    // m_foundHandleOut m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 215 flags:  enum: 
    // m_timeSinceLastModify m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 216 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_rangeIndexForEventToSendNextUpdate m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 220 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbSenseHandleModifier : hkbModifier
    {

        public hkbHandle/*struct void*/ m_handle;
        public Vector4 m_sensorLocalOffset;
        public List<hkbSenseHandleModifierRange> m_ranges;
        public hkbHandle /*pointer struct*/ m_handleOut;
        public hkbHandle /*pointer struct*/ m_handleIn;
        public string m_localFrameName;
        public string m_sensorLocalFrameName;
        public float m_minDistance;
        public float m_maxDistance;
        public float m_distanceOut;
        public uint m_collisionFilterInfo;
        public short m_sensorRagdollBoneIndex;
        public short m_sensorAnimationBoneIndex;
        public sbyte m_sensingMode;
        public bool m_extrapolateSensorPosition;
        public bool m_keepFirstSensedHandle;
        public bool m_foundHandleOut;
        public float m_timeSinceLastModify;
        public int m_rangeIndexForEventToSendNextUpdate;

        public override uint Signature => 0x2a064d99;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_handle = new hkbHandle();
            m_handle.Read(des,br);
            m_sensorLocalOffset = br.ReadVector4();
            m_ranges = des.ReadClassArray<hkbSenseHandleModifierRange>(br);
            m_handleOut = des.ReadClassPointer<hkbHandle>(br);
            m_handleIn = des.ReadClassPointer<hkbHandle>(br);
            m_localFrameName = des.ReadStringPointer(br);
            m_sensorLocalFrameName = des.ReadStringPointer(br);
            m_minDistance = br.ReadSingle();
            m_maxDistance = br.ReadSingle();
            m_distanceOut = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            m_sensorRagdollBoneIndex = br.ReadInt16();
            m_sensorAnimationBoneIndex = br.ReadInt16();
            m_sensingMode = br.ReadSByte();
            m_extrapolateSensorPosition = br.ReadBoolean();
            m_keepFirstSensedHandle = br.ReadBoolean();
            m_foundHandleOut = br.ReadBoolean();
            m_timeSinceLastModify = br.ReadSingle();
            m_rangeIndexForEventToSendNextUpdate = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_handle.Write(s, bw);
            bw.WriteVector4(m_sensorLocalOffset);
            s.WriteClassArray<hkbSenseHandleModifierRange>(bw, m_ranges);
            s.WriteClassPointer(bw, m_handleOut);
            s.WriteClassPointer(bw, m_handleIn);
            s.WriteStringPointer(bw, m_localFrameName);
            s.WriteStringPointer(bw, m_sensorLocalFrameName);
            bw.WriteSingle(m_minDistance);
            bw.WriteSingle(m_maxDistance);
            bw.WriteSingle(m_distanceOut);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.WriteInt16(m_sensorRagdollBoneIndex);
            bw.WriteInt16(m_sensorAnimationBoneIndex);
            s.WriteSByte(bw, m_sensingMode);
            bw.WriteBoolean(m_extrapolateSensorPosition);
            bw.WriteBoolean(m_keepFirstSensedHandle);
            bw.WriteBoolean(m_foundHandleOut);
            bw.WriteSingle(m_timeSinceLastModify);
            bw.WriteInt32(m_rangeIndexForEventToSendNextUpdate);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

