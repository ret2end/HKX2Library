using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkSkinnedRefMeshShape : hkMeshShape
    {
        public List<short> m_bones;
        public List<Vector4> m_localFromRootTransforms;
        public string m_name;

        public hkSkinnedMeshShape m_skinnedMeshShape;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_skinnedMeshShape = des.ReadClassPointer<hkSkinnedMeshShape>(br);
            m_bones = des.ReadInt16Array(br);
            m_localFromRootTransforms = des.ReadVector4Array(br);
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_skinnedMeshShape);
            s.WriteInt16Array(bw, m_bones);
            s.WriteVector4Array(bw, m_localFromRootTransforms);
            s.WriteStringPointer(bw, m_name);
        }
    }
}