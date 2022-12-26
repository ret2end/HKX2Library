using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexTransformShape Signatire: 0xae3e5017 size: 128 flags: FLAGS_NONE

    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpConvexTransformShape : hkpConvexTransformShapeBase
    {

        public Matrix4x4 m_transform;

        public override uint Signature => 0xae3e5017;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_transform = des.ReadTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteTransform(bw, m_transform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

