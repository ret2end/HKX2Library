using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkModifierLeg Signatire: 0x9f3e3a04 size: 160 flags: FLAGS_NONE

    // m_originalAnkleTransformMS m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_prevAnkleRotLS m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_kneeAxisLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_footEndLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_ungroundedEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_footPlantedAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_footRaisedAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags:  enum: 
    // m_maxAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_minAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags:  enum: 
    // m_maxKneeAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_minKneeAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    // m_verticalError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags:  enum: 
    // m_maxAnkleAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 140 flags:  enum: 
    // m_hipIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_kneeIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 146 flags:  enum: 
    // m_ankleIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 148 flags:  enum: 
    // m_hitSomething m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 150 flags:  enum: 
    // m_isPlantedMS m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 151 flags:  enum: 
    // m_isOriginalAnkleTransformMSSet m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 152 flags:  enum: 
    
    public class hkbFootIkModifierLeg : IHavokObject
    {

        public Matrix4x4 m_originalAnkleTransformMS;
        public Quaternion m_prevAnkleRotLS;
        public Vector4 m_kneeAxisLS;
        public Vector4 m_footEndLS;
        public hkbEventProperty/*struct void*/ m_ungroundedEvent;
        public float m_footPlantedAnkleHeightMS;
        public float m_footRaisedAnkleHeightMS;
        public float m_maxAnkleHeightMS;
        public float m_minAnkleHeightMS;
        public float m_maxKneeAngleDegrees;
        public float m_minKneeAngleDegrees;
        public float m_verticalError;
        public float m_maxAnkleAngleDegrees;
        public short m_hipIndex;
        public short m_kneeIndex;
        public short m_ankleIndex;
        public bool m_hitSomething;
        public bool m_isPlantedMS;
        public bool m_isOriginalAnkleTransformMSSet;

        public uint Signature => 0x9f3e3a04;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_originalAnkleTransformMS = des.ReadQSTransform(br);
            m_prevAnkleRotLS = des.ReadQuaternion(br);
            m_kneeAxisLS = br.ReadVector4();
            m_footEndLS = br.ReadVector4();
            m_ungroundedEvent = new hkbEventProperty();
            m_ungroundedEvent.Read(des,br);
            m_footPlantedAnkleHeightMS = br.ReadSingle();
            m_footRaisedAnkleHeightMS = br.ReadSingle();
            m_maxAnkleHeightMS = br.ReadSingle();
            m_minAnkleHeightMS = br.ReadSingle();
            m_maxKneeAngleDegrees = br.ReadSingle();
            m_minKneeAngleDegrees = br.ReadSingle();
            m_verticalError = br.ReadSingle();
            m_maxAnkleAngleDegrees = br.ReadSingle();
            m_hipIndex = br.ReadInt16();
            m_kneeIndex = br.ReadInt16();
            m_ankleIndex = br.ReadInt16();
            m_hitSomething = br.ReadBoolean();
            m_isPlantedMS = br.ReadBoolean();
            m_isOriginalAnkleTransformMSSet = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteQSTransform(bw, m_originalAnkleTransformMS);
            s.WriteQuaternion(bw, m_prevAnkleRotLS);
            bw.WriteVector4(m_kneeAxisLS);
            bw.WriteVector4(m_footEndLS);
            m_ungroundedEvent.Write(s, bw);
            bw.WriteSingle(m_footPlantedAnkleHeightMS);
            bw.WriteSingle(m_footRaisedAnkleHeightMS);
            bw.WriteSingle(m_maxAnkleHeightMS);
            bw.WriteSingle(m_minAnkleHeightMS);
            bw.WriteSingle(m_maxKneeAngleDegrees);
            bw.WriteSingle(m_minKneeAngleDegrees);
            bw.WriteSingle(m_verticalError);
            bw.WriteSingle(m_maxAnkleAngleDegrees);
            bw.WriteInt16(m_hipIndex);
            bw.WriteInt16(m_kneeIndex);
            bw.WriteInt16(m_ankleIndex);
            bw.WriteBoolean(m_hitSomething);
            bw.WriteBoolean(m_isPlantedMS);
            bw.WriteBoolean(m_isOriginalAnkleTransformMSSet);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

