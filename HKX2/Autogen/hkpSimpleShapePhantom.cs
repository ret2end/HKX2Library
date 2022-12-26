using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSimpleShapePhantom Signatire: 0x32a2a8a8 size: 448 flags: FLAGS_NONE

    // m_collisionDetails m_class: hkpSimpleShapePhantomCollisionDetail Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 416 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_orderDirty m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 432 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpSimpleShapePhantom : hkpShapePhantom
    {

        public List<hkpSimpleShapePhantomCollisionDetail> m_collisionDetails;
        public bool m_orderDirty;

        public override uint Signature => 0x32a2a8a8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_collisionDetails = des.ReadClassArray<hkpSimpleShapePhantomCollisionDetail>(br);
            m_orderDirty = br.ReadBoolean();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkpSimpleShapePhantomCollisionDetail>(bw, m_collisionDetails);
            bw.WriteBoolean(m_orderDirty);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

