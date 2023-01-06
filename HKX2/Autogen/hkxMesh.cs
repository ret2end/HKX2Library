using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxMesh Signatire: 0xf2edcc5f size: 48 flags: FLAGS_NONE

    // m_sections m_class: hkxMeshSection Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_userChannelInfos m_class: hkxMeshUserChannelInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkxMesh : hkReferencedObject
    {
        public List<hkxMeshSection> m_sections = new List<hkxMeshSection>();
        public List<hkxMeshUserChannelInfo> m_userChannelInfos = new List<hkxMeshUserChannelInfo>();

        public override uint Signature => 0xf2edcc5f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_sections = des.ReadClassPointerArray<hkxMeshSection>(br);
            m_userChannelInfos = des.ReadClassPointerArray<hkxMeshUserChannelInfo>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkxMeshSection>(bw, m_sections);
            s.WriteClassPointerArray<hkxMeshUserChannelInfo>(bw, m_userChannelInfos);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_sections = xd.ReadClassPointerArray<hkxMeshSection>(xe, nameof(m_sections));
            m_userChannelInfos = xd.ReadClassPointerArray<hkxMeshUserChannelInfo>(xe, nameof(m_userChannelInfos));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkxMeshSection>(xe, nameof(m_sections), m_sections);
            xs.WriteClassPointerArray<hkxMeshUserChannelInfo>(xe, nameof(m_userChannelInfos), m_userChannelInfos);
        }
    }
}

