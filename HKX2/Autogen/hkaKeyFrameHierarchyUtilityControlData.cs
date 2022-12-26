using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaKeyFrameHierarchyUtilityControlData Signatire: 0xa3d0ac71 size: 48 flags: FLAGS_NONE

    // m_hierarchyGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_velocityDamping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_accelerationGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_velocityGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_positionGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_positionMaxLinearVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_positionMaxAngularVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_snapGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_snapMaxLinearVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_snapMaxAngularVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_snapMaxLinearDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_snapMaxAngularDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    
    public class hkaKeyFrameHierarchyUtilityControlData : IHavokObject
    {

        public float m_hierarchyGain;
        public float m_velocityDamping;
        public float m_accelerationGain;
        public float m_velocityGain;
        public float m_positionGain;
        public float m_positionMaxLinearVelocity;
        public float m_positionMaxAngularVelocity;
        public float m_snapGain;
        public float m_snapMaxLinearVelocity;
        public float m_snapMaxAngularVelocity;
        public float m_snapMaxLinearDistance;
        public float m_snapMaxAngularDistance;

        public uint Signature => 0xa3d0ac71;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_hierarchyGain = br.ReadSingle();
            m_velocityDamping = br.ReadSingle();
            m_accelerationGain = br.ReadSingle();
            m_velocityGain = br.ReadSingle();
            m_positionGain = br.ReadSingle();
            m_positionMaxLinearVelocity = br.ReadSingle();
            m_positionMaxAngularVelocity = br.ReadSingle();
            m_snapGain = br.ReadSingle();
            m_snapMaxLinearVelocity = br.ReadSingle();
            m_snapMaxAngularVelocity = br.ReadSingle();
            m_snapMaxLinearDistance = br.ReadSingle();
            m_snapMaxAngularDistance = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_hierarchyGain);
            bw.WriteSingle(m_velocityDamping);
            bw.WriteSingle(m_accelerationGain);
            bw.WriteSingle(m_velocityGain);
            bw.WriteSingle(m_positionGain);
            bw.WriteSingle(m_positionMaxLinearVelocity);
            bw.WriteSingle(m_positionMaxAngularVelocity);
            bw.WriteSingle(m_snapGain);
            bw.WriteSingle(m_snapMaxLinearVelocity);
            bw.WriteSingle(m_snapMaxAngularVelocity);
            bw.WriteSingle(m_snapMaxLinearDistance);
            bw.WriteSingle(m_snapMaxAngularDistance);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

