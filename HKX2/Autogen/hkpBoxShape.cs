using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBoxShape Signatire: 0x3444d2d5 size: 64 flags: FLAGS_NONE

    // m_halfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpBoxShape : hkpConvexShape
    {

        public Vector4 m_halfExtents;

        public override uint Signature => 0x3444d2d5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_halfExtents = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_halfExtents);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

