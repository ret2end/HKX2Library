using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBlenderGeneratorChild Signatire: 0xe2b384b0 size: 80 flags: FLAGS_NONE

    // m_generator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_boneWeights m_class: hkbBoneWeightArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 56 flags:  enum: 
    // m_weight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_worldFromModelWeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    
    public class hkbBlenderGeneratorChild : hkbBindable
    {

        public hkbGenerator /*pointer struct*/ m_generator;
        public hkbBoneWeightArray /*pointer struct*/ m_boneWeights;
        public float m_weight;
        public float m_worldFromModelWeight;

        public override uint Signature => 0xe2b384b0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_generator = des.ReadClassPointer<hkbGenerator>(br);
            m_boneWeights = des.ReadClassPointer<hkbBoneWeightArray>(br);
            m_weight = br.ReadSingle();
            m_worldFromModelWeight = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_generator);
            s.WriteClassPointer(bw, m_boneWeights);
            bw.WriteSingle(m_weight);
            bw.WriteSingle(m_worldFromModelWeight);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

