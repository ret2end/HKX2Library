using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpConvexVerticesShape : hkpConvexShape
    {
        public Vector4 m_aabbCenter;

        public Vector4 m_aabbHalfExtents;
        public hkpConvexVerticesConnectivity m_connectivity;
        public int m_numVertices;
        public List<Vector4> m_planeEquations;
        public List<Matrix4x4> m_rotatedVertices;
        public override uint Signature => 0xC21C8B5A;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_aabbHalfExtents = des.ReadVector4(br);
            m_aabbCenter = des.ReadVector4(br);
            m_rotatedVertices = des.ReadMatrix3Array(br);
            m_numVertices = br.ReadInt32();
            br.ReadBoolean(); // useSpuBuffer
            br.ReadByte();
            br.ReadByte();
            br.ReadByte();
            m_planeEquations = des.ReadVector4Array(br);
            m_connectivity = des.ReadClassPointer<hkpConvexVerticesConnectivity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteVector4(bw, m_aabbHalfExtents);
            s.WriteVector4(bw, m_aabbCenter);
            s.WriteMatrix3Array(bw, m_rotatedVertices);
            bw.WriteInt32(m_numVertices);
            bw.WriteBoolean(false); // useSpuBuffer
            bw.WriteByte(0);
            bw.WriteByte(0);
            bw.WriteByte(0);
            s.WriteVector4Array(bw, m_planeEquations);
            s.WriteClassPointer(bw, m_connectivity);
        }
    }
}