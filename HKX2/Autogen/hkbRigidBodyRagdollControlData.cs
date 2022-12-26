using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRigidBodyRagdollControlData Signatire: 0x1e0bc068 size: 64 flags: FLAGS_NONE

    // m_keyFrameHierarchyControlData m_class: hkaKeyFrameHierarchyUtilityControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_durationToBlend m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkbRigidBodyRagdollControlData : IHavokObject
    {

        public hkaKeyFrameHierarchyUtilityControlData/*struct void*/ m_keyFrameHierarchyControlData;
        public float m_durationToBlend;

        public uint Signature => 0x1e0bc068;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_keyFrameHierarchyControlData = new hkaKeyFrameHierarchyUtilityControlData();
            m_keyFrameHierarchyControlData.Read(des,br);
            m_durationToBlend = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_keyFrameHierarchyControlData.Write(s, bw);
            bw.WriteSingle(m_durationToBlend);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

