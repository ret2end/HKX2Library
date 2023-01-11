using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpConvexVerticesConnectivity Signatire: 0x63d38e9c size: 48 flags: FLAGS_NONE

    // m_vertexIndices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_numVerticesPerFace m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkpConvexVerticesConnectivity : hkReferencedObject
    {
        public IList<ushort> m_vertexIndices { set; get; } = new List<ushort>();
        public IList<byte> m_numVerticesPerFace { set; get; } = new List<byte>();

        public override uint Signature => 0x63d38e9c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexIndices = des.ReadUInt16Array(br);
            m_numVerticesPerFace = des.ReadByteArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_vertexIndices);
            s.WriteByteArray(bw, m_numVerticesPerFace);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_vertexIndices = xd.ReadUInt16Array(xe, nameof(m_vertexIndices));
            m_numVerticesPerFace = xd.ReadByteArray(xe, nameof(m_numVerticesPerFace));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_vertexIndices), m_vertexIndices);
            xs.WriteNumberArray(xe, nameof(m_numVerticesPerFace), m_numVerticesPerFace);
        }
    }
}

