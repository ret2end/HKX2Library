using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkaiObstacleGenerator : hkReferencedObject
    {
        public List<hkaiAvoidanceSolverBoundaryObstacle> m_boundaries;
        public bool m_clipBoundaries;
        public List<hkaiAvoidanceSolverSphereObstacle> m_spheres;
        public Matrix4x4 m_transform;
        public bool m_useBoundaries;
        public ulong m_userData;

        public bool m_useSpheres;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_useSpheres = br.ReadBoolean();
            m_useBoundaries = br.ReadBoolean();
            m_clipBoundaries = br.ReadBoolean();
            br.ReadByte();
            m_transform = des.ReadTransform(br);
            m_spheres = des.ReadClassArray<hkaiAvoidanceSolverSphereObstacle>(br);
            m_boundaries = des.ReadClassArray<hkaiAvoidanceSolverBoundaryObstacle>(br);
            m_userData = br.ReadUInt64();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_useSpheres);
            bw.WriteBoolean(m_useBoundaries);
            bw.WriteBoolean(m_clipBoundaries);
            bw.WriteByte(0);
            s.WriteTransform(bw, m_transform);
            s.WriteClassArray(bw, m_spheres);
            s.WriteClassArray(bw, m_boundaries);
            bw.WriteUInt64(m_userData);
            bw.WriteUInt64(0);
        }
    }
}