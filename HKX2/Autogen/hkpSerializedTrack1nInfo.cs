using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSerializedTrack1nInfo Signatire: 0xf12d48d9 size: 32 flags: FLAGS_NONE

    // m_sectors m_class: hkpAgent1nSector Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_subTracks m_class: hkpSerializedSubTrack1nInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkpSerializedTrack1nInfo : IHavokObject
    {
        public List<hkpAgent1nSector> m_sectors;
        public List<hkpSerializedSubTrack1nInfo> m_subTracks;

        public virtual uint Signature => 0xf12d48d9;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_sectors = des.ReadClassPointerArray<hkpAgent1nSector>(br);
            m_subTracks = des.ReadClassPointerArray<hkpSerializedSubTrack1nInfo>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointerArray<hkpAgent1nSector>(bw, m_sectors);
            s.WriteClassPointerArray<hkpSerializedSubTrack1nInfo>(bw, m_subTracks);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointerArray<hkpAgent1nSector>(xe, nameof(m_sectors), m_sectors);
            xs.WriteClassPointerArray<hkpSerializedSubTrack1nInfo>(xe, nameof(m_subTracks), m_subTracks);
        }
    }
}

