using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBvShape Signatire: 0x286eb64c size: 56 flags: FLAGS_NONE

    // m_boundingVolumeShape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_childShape m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkpBvShape : hkpShape
    {

        public hkpShape /*pointer struct*/ m_boundingVolumeShape;
        public hkpSingleShapeContainer/*struct void*/ m_childShape;

        public override uint Signature => 0x286eb64c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_boundingVolumeShape = des.ReadClassPointer<hkpShape>(br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_boundingVolumeShape);
            m_childShape.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

