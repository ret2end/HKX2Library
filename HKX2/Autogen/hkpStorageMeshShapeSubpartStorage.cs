using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpStorageMeshShapeSubpartStorage Signatire: 0xbf27438 size: 112 flags: FLAGS_NONE

    // m_vertices m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_indices16 m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_indices32 m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_materialIndices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_materials m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_materialIndices16 m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    public partial class hkpStorageMeshShapeSubpartStorage : hkReferencedObject
    {
        public List<float> m_vertices;
        public List<ushort> m_indices16;
        public List<uint> m_indices32;
        public List<byte> m_materialIndices;
        public List<uint> m_materials;
        public List<ushort> m_materialIndices16;

        public override uint Signature => 0xbf27438;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertices = des.ReadSingleArray(br);
            m_indices16 = des.ReadUInt16Array(br);
            m_indices32 = des.ReadUInt32Array(br);
            m_materialIndices = des.ReadByteArray(br);
            m_materials = des.ReadUInt32Array(br);
            m_materialIndices16 = des.ReadUInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_vertices);
            s.WriteUInt16Array(bw, m_indices16);
            s.WriteUInt32Array(bw, m_indices32);
            s.WriteByteArray(bw, m_materialIndices);
            s.WriteUInt32Array(bw, m_materials);
            s.WriteUInt16Array(bw, m_materialIndices16);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloatArray(xe, nameof(m_vertices), m_vertices);
            xs.WriteNumberArray(xe, nameof(m_indices16), m_indices16);
            xs.WriteNumberArray(xe, nameof(m_indices32), m_indices32);
            xs.WriteNumberArray(xe, nameof(m_materialIndices), m_materialIndices);
            xs.WriteNumberArray(xe, nameof(m_materials), m_materials);
            xs.WriteNumberArray(xe, nameof(m_materialIndices16), m_materialIndices16);
        }
    }
}

