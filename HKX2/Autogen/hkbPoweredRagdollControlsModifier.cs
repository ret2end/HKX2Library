using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbPoweredRagdollControlsModifier Signatire: 0x7cb54065 size: 144 flags: FLAGS_NONE

    // m_controlData m_class: hkbPoweredRagdollControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_bones m_class: hkbBoneIndexArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 112 flags:  enum: 
    // m_worldFromModelModeData m_class: hkbWorldFromModelModeData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_boneWeights m_class: hkbBoneWeightArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 128 flags:  enum: 
    
    public class hkbPoweredRagdollControlsModifier : hkbModifier
    {

        public hkbPoweredRagdollControlData/*struct void*/ m_controlData;
        public hkbBoneIndexArray /*pointer struct*/ m_bones;
        public hkbWorldFromModelModeData/*struct void*/ m_worldFromModelModeData;
        public hkbBoneWeightArray /*pointer struct*/ m_boneWeights;

        public override uint Signature => 0x7cb54065;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_controlData = new hkbPoweredRagdollControlData();
            m_controlData.Read(des,br);
            m_bones = des.ReadClassPointer<hkbBoneIndexArray>(br);
            m_worldFromModelModeData = new hkbWorldFromModelModeData();
            m_worldFromModelModeData.Read(des,br);
            m_boneWeights = des.ReadClassPointer<hkbBoneWeightArray>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_controlData.Write(s, bw);
            s.WriteClassPointer(bw, m_bones);
            m_worldFromModelModeData.Write(s, bw);
            s.WriteClassPointer(bw, m_boneWeights);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

