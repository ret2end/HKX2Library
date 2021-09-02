using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkaMeshBinding : hkReferencedObject
    {
        public List<Matrix4x4> m_boneFromSkinMeshTransforms;
        public List<hkaMeshBindingMapping> m_mappings;

        public hkxMesh m_mesh;
        public string m_name;
        public string m_originalSkeletonName;
        public hkaSkeleton m_skeleton;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_mesh = des.ReadClassPointer<hkxMesh>(br);
            m_originalSkeletonName = des.ReadStringPointer(br);
            m_name = des.ReadStringPointer(br);
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);
            m_mappings = des.ReadClassArray<hkaMeshBindingMapping>(br);
            m_boneFromSkinMeshTransforms = des.ReadTransformArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_mesh);
            s.WriteStringPointer(bw, m_originalSkeletonName);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_skeleton);
            s.WriteClassArray(bw, m_mappings);
            s.WriteTransformArray(bw, m_boneFromSkinMeshTransforms);
        }
    }
}