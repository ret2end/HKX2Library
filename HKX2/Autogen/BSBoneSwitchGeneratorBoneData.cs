using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSBoneSwitchGeneratorBoneData Signatire: 0xc1215be6 size: 64 flags: FLAGS_NONE

    // m_pGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_spBoneWeight m_class: hkbBoneWeightArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 56 flags:  enum: 
    
    public class BSBoneSwitchGeneratorBoneData : hkbBindable
    {

        public hkbGenerator /*pointer struct*/ m_pGenerator;
        public hkbBoneWeightArray /*pointer struct*/ m_spBoneWeight;

        public override uint Signature => 0xc1215be6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_pGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_spBoneWeight = des.ReadClassPointer<hkbBoneWeightArray>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_pGenerator);
            s.WriteClassPointer(bw, m_spBoneWeight);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

