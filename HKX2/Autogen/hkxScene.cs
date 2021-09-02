using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkxScene : hkReferencedObject
    {
        public Matrix4x4 m_appliedTransform;
        public string m_asset;
        public List<hkxCamera> m_cameras;
        public List<hkxTextureFile> m_externalTextures;
        public List<hkxTextureInplace> m_inplaceTextures;
        public List<hkxLight> m_lights;
        public List<hkxMaterial> m_materials;

        public string m_modeller;
        public uint m_numFrames;
        public hkxNode m_rootNode;
        public float m_sceneLength;
        public List<hkxNodeSelectionSet> m_selectionSets;
        public List<hkxSkinBinding> m_skinBindings;
        public List<hkxSpline> m_splines;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_modeller = des.ReadStringPointer(br);
            m_asset = des.ReadStringPointer(br);
            m_sceneLength = br.ReadSingle();
            m_numFrames = br.ReadUInt32();
            m_rootNode = des.ReadClassPointer<hkxNode>(br);
            m_selectionSets = des.ReadClassPointerArray<hkxNodeSelectionSet>(br);
            m_cameras = des.ReadClassPointerArray<hkxCamera>(br);
            m_lights = des.ReadClassPointerArray<hkxLight>(br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_materials = des.ReadClassPointerArray<hkxMaterial>(br);
            m_inplaceTextures = des.ReadClassPointerArray<hkxTextureInplace>(br);
            m_externalTextures = des.ReadClassPointerArray<hkxTextureFile>(br);
            m_skinBindings = des.ReadClassPointerArray<hkxSkinBinding>(br);
            m_splines = des.ReadClassPointerArray<hkxSpline>(br);
            m_appliedTransform = des.ReadMatrix3(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_modeller);
            s.WriteStringPointer(bw, m_asset);
            bw.WriteSingle(m_sceneLength);
            bw.WriteUInt32(m_numFrames);
            s.WriteClassPointer(bw, m_rootNode);
            s.WriteClassPointerArray(bw, m_selectionSets);
            s.WriteClassPointerArray(bw, m_cameras);
            s.WriteClassPointerArray(bw, m_lights);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            s.WriteClassPointerArray(bw, m_materials);
            s.WriteClassPointerArray(bw, m_inplaceTextures);
            s.WriteClassPointerArray(bw, m_externalTextures);
            s.WriteClassPointerArray(bw, m_skinBindings);
            s.WriteClassPointerArray(bw, m_splines);
            s.WriteMatrix3(bw, m_appliedTransform);
        }
    }
}