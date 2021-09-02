using System.Collections.Generic;

namespace HKX2
{
    public class hkaiNavMeshSimplificationSnapshot : IHavokObject
    {
        public List<hkaiCarver> m_carvers;
        public hkBitField m_cuttingTriangles;

        public hkGeometry m_geometry;
        public hkaiNavMeshGenerationSettings m_settings;
        public hkaiNavMesh m_unsimplifiedNavMesh;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_geometry = des.ReadClassPointer<hkGeometry>(br);
            m_carvers = des.ReadClassPointerArray<hkaiCarver>(br);
            m_cuttingTriangles = new hkBitField();
            m_cuttingTriangles.Read(des, br);
            m_settings = new hkaiNavMeshGenerationSettings();
            m_settings.Read(des, br);
            m_unsimplifiedNavMesh = des.ReadClassPointer<hkaiNavMesh>(br);
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_geometry);
            s.WriteClassPointerArray(bw, m_carvers);
            m_cuttingTriangles.Write(s, bw);
            m_settings.Write(s, bw);
            s.WriteClassPointer(bw, m_unsimplifiedNavMesh);
            bw.WriteUInt64(0);
        }
    }
}