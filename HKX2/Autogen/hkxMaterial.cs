using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxMaterial Signatire: 0x2954537a size: 176 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_stages m_class: hkxMaterialTextureStage Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_diffuseColor m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_ambientColor m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_specularColor m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_emissiveColor m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_subMaterials m_class: hkxMaterial Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_extraData m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_properties m_class: hkxMaterialProperty Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    public partial class hkxMaterial : hkxAttributeHolder
    {
        public string m_name;
        public List<hkxMaterialTextureStage> m_stages;
        public Vector4 m_diffuseColor;
        public Vector4 m_ambientColor;
        public Vector4 m_specularColor;
        public Vector4 m_emissiveColor;
        public List<hkxMaterial> m_subMaterials;
        public hkReferencedObject m_extraData;
        public List<hkxMaterialProperty> m_properties;

        public override uint Signature => 0x2954537a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_stages = des.ReadClassArray<hkxMaterialTextureStage>(br);
            br.Position += 8;
            m_diffuseColor = br.ReadVector4();
            m_ambientColor = br.ReadVector4();
            m_specularColor = br.ReadVector4();
            m_emissiveColor = br.ReadVector4();
            m_subMaterials = des.ReadClassPointerArray<hkxMaterial>(br);
            m_extraData = des.ReadClassPointer<hkReferencedObject>(br);
            m_properties = des.ReadClassArray<hkxMaterialProperty>(br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray<hkxMaterialTextureStage>(bw, m_stages);
            bw.Position += 8;
            bw.WriteVector4(m_diffuseColor);
            bw.WriteVector4(m_ambientColor);
            bw.WriteVector4(m_specularColor);
            bw.WriteVector4(m_emissiveColor);
            s.WriteClassPointerArray<hkxMaterial>(bw, m_subMaterials);
            s.WriteClassPointer(bw, m_extraData);
            s.WriteClassArray<hkxMaterialProperty>(bw, m_properties);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassArray<hkxMaterialTextureStage>(xe, nameof(m_stages), m_stages);
            xs.WriteVector4(xe, nameof(m_diffuseColor), m_diffuseColor);
            xs.WriteVector4(xe, nameof(m_ambientColor), m_ambientColor);
            xs.WriteVector4(xe, nameof(m_specularColor), m_specularColor);
            xs.WriteVector4(xe, nameof(m_emissiveColor), m_emissiveColor);
            xs.WriteClassPointerArray<hkxMaterial>(xe, nameof(m_subMaterials), m_subMaterials);
            xs.WriteClassPointer(xe, nameof(m_extraData), m_extraData);
            xs.WriteClassArray<hkxMaterialProperty>(xe, nameof(m_properties), m_properties);
        }
    }
}

