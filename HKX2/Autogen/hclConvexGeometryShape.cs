using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclConvexGeometryShape : hclShape
    {
        public Vector4 m_geomCentroid;
        public List<byte> m_gridCells;
        public ushort m_gridRes;
        public Vector4 m_invCellSize;
        public Matrix4x4 m_localFromWorld;
        public hkAabb m_objAabb;
        public List<Matrix4x4> m_tetrahedraEquations;

        public List<ushort> m_tetrahedraGrid;
        public Matrix4x4 m_worldFromLocal;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_tetrahedraGrid = des.ReadUInt16Array(br);
            m_gridCells = des.ReadByteArray(br);
            m_tetrahedraEquations = des.ReadMatrix4Array(br);
            m_localFromWorld = des.ReadTransform(br);
            m_worldFromLocal = des.ReadTransform(br);
            m_objAabb = new hkAabb();
            m_objAabb.Read(des, br);
            m_geomCentroid = des.ReadVector4(br);
            m_invCellSize = des.ReadVector4(br);
            m_gridRes = br.ReadUInt16();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_tetrahedraGrid);
            s.WriteByteArray(bw, m_gridCells);
            s.WriteMatrix4Array(bw, m_tetrahedraEquations);
            s.WriteTransform(bw, m_localFromWorld);
            s.WriteTransform(bw, m_worldFromLocal);
            m_objAabb.Write(s, bw);
            s.WriteVector4(bw, m_geomCentroid);
            s.WriteVector4(bw, m_invCellSize);
            bw.WriteUInt16(m_gridRes);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
        }
    }
}