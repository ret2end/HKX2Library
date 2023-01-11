using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxMaterialShaderSet Signatire: 0x154650f3 size: 32 flags: FLAGS_NONE

    // m_shaders m_class: hkxMaterialShader Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkxMaterialShaderSet : hkReferencedObject
    {
        public IList<hkxMaterialShader> m_shaders { set; get; } = new List<hkxMaterialShader>();

        public override uint Signature => 0x154650f3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_shaders = des.ReadClassPointerArray<hkxMaterialShader>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_shaders);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_shaders = xd.ReadClassPointerArray<hkxMaterialShader>(xe, nameof(m_shaders));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkxMaterialShader>(xe, nameof(m_shaders), m_shaders);
        }
    }
}

