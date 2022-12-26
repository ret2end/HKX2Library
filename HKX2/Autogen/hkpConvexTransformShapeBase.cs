using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexTransformShapeBase Signatire: 0xfbd72f9 size: 64 flags: FLAGS_NONE

    // m_childShape m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_childShapeSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpConvexTransformShapeBase : hkpConvexShape
    {

        public hkpSingleShapeContainer/*struct void*/ m_childShape;
        public int m_childShapeSize;

        public override uint Signature => 0xfbd72f9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des,br);
            m_childShapeSize = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_childShape.Write(s, bw);
            bw.WriteInt32(m_childShapeSize);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

