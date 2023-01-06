using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpStorageMeshShape Signatire: 0xbefd8b39 size: 144 flags: FLAGS_NONE

    // m_storage m_class: hkpStorageMeshShapeSubpartStorage Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    public partial class hkpStorageMeshShape : hkpMeshShape
    {
        public List<hkpStorageMeshShapeSubpartStorage> m_storage = new List<hkpStorageMeshShapeSubpartStorage>();

        public override uint Signature => 0xbefd8b39;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_storage = des.ReadClassPointerArray<hkpStorageMeshShapeSubpartStorage>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkpStorageMeshShapeSubpartStorage>(bw, m_storage);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_storage = xd.ReadClassPointerArray<hkpStorageMeshShapeSubpartStorage>(xe, nameof(m_storage));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpStorageMeshShapeSubpartStorage>(xe, nameof(m_storage), m_storage);
        }
    }
}

