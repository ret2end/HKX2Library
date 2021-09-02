using System.Numerics;

namespace HKX2
{
    public class hkaiEdgePathEdge : IHavokObject
    {
        public hkaiPersistentEdgeKey m_edge;
        public byte m_flags;
        public Matrix4x4 m_followingTransform;

        public Vector4 m_left;
        public hkaiEdgePathFollowingCornerInfo m_leftFollowingCorner;
        public Vector4 m_right;
        public hkaiEdgePathFollowingCornerInfo m_rightFollowingCorner;
        public Vector4 m_up;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_left = des.ReadVector4(br);
            m_right = des.ReadVector4(br);
            m_up = des.ReadVector4(br);
            m_followingTransform = des.ReadMatrix4(br);
            m_edge = new hkaiPersistentEdgeKey();
            m_edge.Read(des, br);
            m_leftFollowingCorner = new hkaiEdgePathFollowingCornerInfo();
            m_leftFollowingCorner.Read(des, br);
            m_rightFollowingCorner = new hkaiEdgePathFollowingCornerInfo();
            m_rightFollowingCorner.Read(des, br);
            m_flags = br.ReadByte();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_left);
            s.WriteVector4(bw, m_right);
            s.WriteVector4(bw, m_up);
            s.WriteMatrix4(bw, m_followingTransform);
            m_edge.Write(s, bw);
            m_leftFollowingCorner.Write(s, bw);
            m_rightFollowingCorner.Write(s, bw);
            bw.WriteByte(m_flags);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}