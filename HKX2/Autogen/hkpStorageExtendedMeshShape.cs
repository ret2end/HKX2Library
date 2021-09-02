using System.Collections.Generic;

namespace HKX2
{
    public class hkpStorageExtendedMeshShape : hkpExtendedMeshShape
    {
        public List<hkpStorageExtendedMeshShapeMeshSubpartStorage> m_meshstorage;
        public List<hkpStorageExtendedMeshShapeShapeSubpartStorage> m_shapestorage;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_meshstorage = des.ReadClassPointerArray<hkpStorageExtendedMeshShapeMeshSubpartStorage>(br);
            m_shapestorage = des.ReadClassPointerArray<hkpStorageExtendedMeshShapeShapeSubpartStorage>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_meshstorage);
            s.WriteClassPointerArray(bw, m_shapestorage);
            bw.WriteUInt64(0);
        }
    }
}