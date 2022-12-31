using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxMeshSection Signatire: 0xe2286cf8 size: 64 flags: FLAGS_NONE

    // m_vertexBuffer m_class: hkxVertexBuffer Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_indexBuffers m_class: hkxIndexBuffer Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_material m_class: hkxMaterial Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_userChannels m_class: hkReferencedObject Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkxMeshSection : hkReferencedObject
    {
        public hkxVertexBuffer m_vertexBuffer;
        public List<hkxIndexBuffer> m_indexBuffers;
        public hkxMaterial m_material;
        public List<hkReferencedObject> m_userChannels;

        public override uint Signature => 0xe2286cf8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexBuffer = des.ReadClassPointer<hkxVertexBuffer>(br);
            m_indexBuffers = des.ReadClassPointerArray<hkxIndexBuffer>(br);
            m_material = des.ReadClassPointer<hkxMaterial>(br);
            m_userChannels = des.ReadClassPointerArray<hkReferencedObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_vertexBuffer);
            s.WriteClassPointerArray<hkxIndexBuffer>(bw, m_indexBuffers);
            s.WriteClassPointer(bw, m_material);
            s.WriteClassPointerArray<hkReferencedObject>(bw, m_userChannels);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_vertexBuffer), m_vertexBuffer);
            xs.WriteClassPointerArray<hkxIndexBuffer>(xe, nameof(m_indexBuffers), m_indexBuffers);
            xs.WriteClassPointer(xe, nameof(m_material), m_material);
            xs.WriteClassPointerArray<hkReferencedObject>(xe, nameof(m_userChannels), m_userChannels);
        }
    }
}

