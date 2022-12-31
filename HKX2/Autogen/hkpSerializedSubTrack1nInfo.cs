using System.Xml.Linq;

namespace HKX2
{
    // hkpSerializedSubTrack1nInfo Signatire: 0x10155a size: 40 flags: FLAGS_NONE

    // m_sectorIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_offsetInSector m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    public partial class hkpSerializedSubTrack1nInfo : hkpSerializedTrack1nInfo
    {
        public int m_sectorIndex;
        public int m_offsetInSector;

        public override uint Signature => 0x10155a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_sectorIndex = br.ReadInt32();
            m_offsetInSector = br.ReadInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_sectorIndex);
            bw.WriteInt32(m_offsetInSector);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_sectorIndex), m_sectorIndex);
            xs.WriteNumber(xe, nameof(m_offsetInSector), m_offsetInSector);
        }
    }
}

