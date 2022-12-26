using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBoneIndexArray Signatire: 0xaa8619 size: 64 flags: FLAGS_NONE

    // m_boneIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkbBoneIndexArray : hkbBindable
    {

        public List<short> m_boneIndices;

        public override uint Signature => 0xaa8619;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_boneIndices = des.ReadInt16Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt16Array(bw, m_boneIndices);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

