using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxScene Signatire: 0x5f673ddd size: 224 flags: FLAGS_NONE

    // m_modeller m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_asset m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_sceneLength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_rootNode m_class: hkxNode Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_selectionSets m_class: hkxNodeSelectionSet Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_cameras m_class: hkxCamera Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_lights m_class: hkxLight Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_meshes m_class: hkxMesh Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_materials m_class: hkxMaterial Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_inplaceTextures m_class: hkxTextureInplace Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_externalTextures m_class: hkxTextureFile Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_skinBindings m_class: hkxSkinBinding Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_appliedTransform m_class:  Type.TYPE_MATRIX3 Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    public partial class hkxScene : hkReferencedObject
    {
        public string m_modeller;
        public string m_asset;
        public float m_sceneLength;
        public hkxNode m_rootNode;
        public List<hkxNodeSelectionSet> m_selectionSets = new List<hkxNodeSelectionSet>();
        public List<hkxCamera> m_cameras = new List<hkxCamera>();
        public List<hkxLight> m_lights = new List<hkxLight>();
        public List<hkxMesh> m_meshes = new List<hkxMesh>();
        public List<hkxMaterial> m_materials = new List<hkxMaterial>();
        public List<hkxTextureInplace> m_inplaceTextures = new List<hkxTextureInplace>();
        public List<hkxTextureFile> m_externalTextures = new List<hkxTextureFile>();
        public List<hkxSkinBinding> m_skinBindings = new List<hkxSkinBinding>();
        public Matrix4x4 m_appliedTransform;

        public override uint Signature => 0x5f673ddd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_modeller = des.ReadStringPointer(br);
            m_asset = des.ReadStringPointer(br);
            m_sceneLength = br.ReadSingle();
            br.Position += 4;
            m_rootNode = des.ReadClassPointer<hkxNode>(br);
            m_selectionSets = des.ReadClassPointerArray<hkxNodeSelectionSet>(br);
            m_cameras = des.ReadClassPointerArray<hkxCamera>(br);
            m_lights = des.ReadClassPointerArray<hkxLight>(br);
            m_meshes = des.ReadClassPointerArray<hkxMesh>(br);
            m_materials = des.ReadClassPointerArray<hkxMaterial>(br);
            m_inplaceTextures = des.ReadClassPointerArray<hkxTextureInplace>(br);
            m_externalTextures = des.ReadClassPointerArray<hkxTextureFile>(br);
            m_skinBindings = des.ReadClassPointerArray<hkxSkinBinding>(br);
            m_appliedTransform = des.ReadMatrix3(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_modeller);
            s.WriteStringPointer(bw, m_asset);
            bw.WriteSingle(m_sceneLength);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_rootNode);
            s.WriteClassPointerArray<hkxNodeSelectionSet>(bw, m_selectionSets);
            s.WriteClassPointerArray<hkxCamera>(bw, m_cameras);
            s.WriteClassPointerArray<hkxLight>(bw, m_lights);
            s.WriteClassPointerArray<hkxMesh>(bw, m_meshes);
            s.WriteClassPointerArray<hkxMaterial>(bw, m_materials);
            s.WriteClassPointerArray<hkxTextureInplace>(bw, m_inplaceTextures);
            s.WriteClassPointerArray<hkxTextureFile>(bw, m_externalTextures);
            s.WriteClassPointerArray<hkxSkinBinding>(bw, m_skinBindings);
            s.WriteMatrix3(bw, m_appliedTransform);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_modeller = xd.ReadString(xe, nameof(m_modeller));
            m_asset = xd.ReadString(xe, nameof(m_asset));
            m_sceneLength = xd.ReadSingle(xe, nameof(m_sceneLength));
            m_rootNode = xd.ReadClassPointer<hkxNode>(xe, nameof(m_rootNode));
            m_selectionSets = xd.ReadClassPointerArray<hkxNodeSelectionSet>(xe, nameof(m_selectionSets));
            m_cameras = xd.ReadClassPointerArray<hkxCamera>(xe, nameof(m_cameras));
            m_lights = xd.ReadClassPointerArray<hkxLight>(xe, nameof(m_lights));
            m_meshes = xd.ReadClassPointerArray<hkxMesh>(xe, nameof(m_meshes));
            m_materials = xd.ReadClassPointerArray<hkxMaterial>(xe, nameof(m_materials));
            m_inplaceTextures = xd.ReadClassPointerArray<hkxTextureInplace>(xe, nameof(m_inplaceTextures));
            m_externalTextures = xd.ReadClassPointerArray<hkxTextureFile>(xe, nameof(m_externalTextures));
            m_skinBindings = xd.ReadClassPointerArray<hkxSkinBinding>(xe, nameof(m_skinBindings));
            m_appliedTransform = xd.ReadMatrix3(xe, nameof(m_appliedTransform));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_modeller), m_modeller);
            xs.WriteString(xe, nameof(m_asset), m_asset);
            xs.WriteFloat(xe, nameof(m_sceneLength), m_sceneLength);
            xs.WriteClassPointer(xe, nameof(m_rootNode), m_rootNode);
            xs.WriteClassPointerArray<hkxNodeSelectionSet>(xe, nameof(m_selectionSets), m_selectionSets);
            xs.WriteClassPointerArray<hkxCamera>(xe, nameof(m_cameras), m_cameras);
            xs.WriteClassPointerArray<hkxLight>(xe, nameof(m_lights), m_lights);
            xs.WriteClassPointerArray<hkxMesh>(xe, nameof(m_meshes), m_meshes);
            xs.WriteClassPointerArray<hkxMaterial>(xe, nameof(m_materials), m_materials);
            xs.WriteClassPointerArray<hkxTextureInplace>(xe, nameof(m_inplaceTextures), m_inplaceTextures);
            xs.WriteClassPointerArray<hkxTextureFile>(xe, nameof(m_externalTextures), m_externalTextures);
            xs.WriteClassPointerArray<hkxSkinBinding>(xe, nameof(m_skinBindings), m_skinBindings);
            xs.WriteMatrix3(xe, nameof(m_appliedTransform), m_appliedTransform);
        }
    }
}

