using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaMeshBinding Signatire: 0x81d9950b size: 72 flags: FLAGS_NONE

    // m_mesh m_class: hkxMesh Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_originalSkeletonName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_skeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_mappings m_class: hkaMeshBindingMapping Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_boneFromSkinMeshTransforms m_class:  Type.TYPE_ARRAY Type.TYPE_TRANSFORM arrSize: 0 offset: 56 flags:  enum: 
    
    public class hkaMeshBinding : hkReferencedObject
    {

        public hkxMesh /*pointer struct*/ m_mesh;
        public string m_originalSkeletonName;
        public hkaSkeleton /*pointer struct*/ m_skeleton;
        public List<hkaMeshBindingMapping> m_mappings;
        public List<Matrix4x4> m_boneFromSkinMeshTransforms;

        public override uint Signature => 0x81d9950b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_mesh = des.ReadClassPointer<hkxMesh>(br);
            m_originalSkeletonName = des.ReadStringPointer(br);
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);
            m_mappings = des.ReadClassArray<hkaMeshBindingMapping>(br);
            m_boneFromSkinMeshTransforms = des.ReadTransformArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_mesh);
            s.WriteStringPointer(bw, m_originalSkeletonName);
            s.WriteClassPointer(bw, m_skeleton);
            s.WriteClassArray<hkaMeshBindingMapping>(bw, m_mappings);
            s.WriteTransformArray(bw, m_boneFromSkinMeshTransforms);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

