using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbKeyframeBonesModifier Signatire: 0x95f66629 size: 104 flags: FLAGS_NONE

    // m_keyframeInfo m_class: hkbKeyframeBonesModifierKeyframeInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_keyframedBonesList m_class: hkbBoneIndexArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags:  enum: 
    
    public class hkbKeyframeBonesModifier : hkbModifier
    {

        public List<hkbKeyframeBonesModifierKeyframeInfo> m_keyframeInfo;
        public hkbBoneIndexArray /*pointer struct*/ m_keyframedBonesList;

        public override uint Signature => 0x95f66629;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_keyframeInfo = des.ReadClassArray<hkbKeyframeBonesModifierKeyframeInfo>(br);
            m_keyframedBonesList = des.ReadClassPointer<hkbBoneIndexArray>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbKeyframeBonesModifierKeyframeInfo>(bw, m_keyframeInfo);
            s.WriteClassPointer(bw, m_keyframedBonesList);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

