using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSimpleShapePhantomCollisionDetail Signatire: 0x98bfa6ce size: 8 flags: FLAGS_NOT_SERIALIZABLE

    // m_collidable m_class: hkpCollidable Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkpSimpleShapePhantomCollisionDetail : IHavokObject
    {

        public hkpCollidable /*pointer struct*/ m_collidable;

        public uint Signature => 0x98bfa6ce;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_collidable = des.ReadClassPointer<hkpCollidable>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_collidable);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

