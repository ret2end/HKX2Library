using System.Collections.Generic;

namespace HKX2
{
    public class hkpStorageMeshShape : hkpMeshShape
    {
        public List<hkpStorageMeshShapeSubpartStorage> m_storage;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_storage = des.ReadClassPointerArray<hkpStorageMeshShapeSubpartStorage>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_storage);
        }
    }
}