using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSingleShapeContainer Signatire: 0x73aa1d38 size: 16 flags: FLAGS_NONE

    // m_childShape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpSingleShapeContainer : hkpShapeContainer
    {

        public hkpShape /*pointer struct*/ m_childShape;

        public override uint Signature => 0x73aa1d38;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_childShape = des.ReadClassPointer<hkpShape>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_childShape);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

