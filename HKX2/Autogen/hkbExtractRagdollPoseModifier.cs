using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbExtractRagdollPoseModifier Signatire: 0x804dcbab size: 88 flags: FLAGS_NONE

    // m_poseMatchingBone0 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_poseMatchingBone1 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 82 flags:  enum: 
    // m_poseMatchingBone2 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_enableComputeWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 86 flags:  enum: 
    
    public class hkbExtractRagdollPoseModifier : hkbModifier
    {

        public short m_poseMatchingBone0;
        public short m_poseMatchingBone1;
        public short m_poseMatchingBone2;
        public bool m_enableComputeWorldFromModel;

        public override uint Signature => 0x804dcbab;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_poseMatchingBone0 = br.ReadInt16();
            m_poseMatchingBone1 = br.ReadInt16();
            m_poseMatchingBone2 = br.ReadInt16();
            m_enableComputeWorldFromModel = br.ReadBoolean();
            br.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt16(m_poseMatchingBone0);
            bw.WriteInt16(m_poseMatchingBone1);
            bw.WriteInt16(m_poseMatchingBone2);
            bw.WriteBoolean(m_enableComputeWorldFromModel);
            bw.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

