using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpStorageMeshShape Signatire: 0xbefd8b39 size: 144 flags: FLAGS_NONE

    // m_storage m_class: hkpStorageMeshShapeSubpartStorage Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 128 flags:  enum: 
    
    public class hkpStorageMeshShape : hkpMeshShape
    {

        public List<hkpStorageMeshShapeSubpartStorage> m_storage;

        public override uint Signature => 0xbefd8b39;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_storage = des.ReadClassPointerArray<hkpStorageMeshShapeSubpartStorage>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpStorageMeshShapeSubpartStorage>(bw, m_storage);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

