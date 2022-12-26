using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBoneWeightArray Signatire: 0xcd902b77 size: 64 flags: FLAGS_NONE

    // m_boneWeights m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkbBoneWeightArray : hkbBindable
    {

        public List<float> m_boneWeights;

        public override uint Signature => 0xcd902b77;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_boneWeights = des.ReadSingleArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSingleArray(bw, m_boneWeights);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
