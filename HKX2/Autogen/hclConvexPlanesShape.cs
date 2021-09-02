using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclConvexPlanesShape : hclShape
    {
        public Vector4 m_geomCentroid;
        public Matrix4x4 m_localFromWorld;
        public hkAabb m_objAabb;

        public List<Vector4> m_planeEquations;
        public Matrix4x4 m_worldFromLocal;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_planeEquations = des.ReadVector4Array(br);
            m_localFromWorld = des.ReadTransform(br);
            m_worldFromLocal = des.ReadTransform(br);
            m_objAabb = new hkAabb();
            m_objAabb.Read(des, br);
            m_geomCentroid = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4Array(bw, m_planeEquations);
            s.WriteTransform(bw, m_localFromWorld);
            s.WriteTransform(bw, m_worldFromLocal);
            m_objAabb.Write(s, bw);
            s.WriteVector4(bw, m_geomCentroid);
        }
    }
}