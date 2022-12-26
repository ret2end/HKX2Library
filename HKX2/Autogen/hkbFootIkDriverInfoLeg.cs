using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkDriverInfoLeg Signatire: 0x224b18d1 size: 96 flags: FLAGS_NONE

    // m_prevAnkleRotLS m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_kneeAxisLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_footEndLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_footPlantedAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_footRaisedAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    // m_maxAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_minAnkleHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_maxKneeAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_minKneeAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_maxAnkleAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_hipIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 
    // m_kneeIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 78 flags:  enum: 
    // m_ankleIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkbFootIkDriverInfoLeg : IHavokObject
    {

        public Quaternion m_prevAnkleRotLS;
        public Vector4 m_kneeAxisLS;
        public Vector4 m_footEndLS;
        public float m_footPlantedAnkleHeightMS;
        public float m_footRaisedAnkleHeightMS;
        public float m_maxAnkleHeightMS;
        public float m_minAnkleHeightMS;
        public float m_maxKneeAngleDegrees;
        public float m_minKneeAngleDegrees;
        public float m_maxAnkleAngleDegrees;
        public short m_hipIndex;
        public short m_kneeIndex;
        public short m_ankleIndex;

        public uint Signature => 0x224b18d1;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_prevAnkleRotLS = des.ReadQuaternion(br);
            m_kneeAxisLS = br.ReadVector4();
            m_footEndLS = br.ReadVector4();
            m_footPlantedAnkleHeightMS = br.ReadSingle();
            m_footRaisedAnkleHeightMS = br.ReadSingle();
            m_maxAnkleHeightMS = br.ReadSingle();
            m_minAnkleHeightMS = br.ReadSingle();
            m_maxKneeAngleDegrees = br.ReadSingle();
            m_minKneeAngleDegrees = br.ReadSingle();
            m_maxAnkleAngleDegrees = br.ReadSingle();
            m_hipIndex = br.ReadInt16();
            m_kneeIndex = br.ReadInt16();
            m_ankleIndex = br.ReadInt16();
            br.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteQuaternion(bw, m_prevAnkleRotLS);
            bw.WriteVector4(m_kneeAxisLS);
            bw.WriteVector4(m_footEndLS);
            bw.WriteSingle(m_footPlantedAnkleHeightMS);
            bw.WriteSingle(m_footRaisedAnkleHeightMS);
            bw.WriteSingle(m_maxAnkleHeightMS);
            bw.WriteSingle(m_minAnkleHeightMS);
            bw.WriteSingle(m_maxKneeAngleDegrees);
            bw.WriteSingle(m_minKneeAngleDegrees);
            bw.WriteSingle(m_maxAnkleAngleDegrees);
            bw.WriteInt16(m_hipIndex);
            bw.WriteInt16(m_kneeIndex);
            bw.WriteInt16(m_ankleIndex);
            bw.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

