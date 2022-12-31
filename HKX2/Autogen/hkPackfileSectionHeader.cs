using System.Xml.Linq;

namespace HKX2
{
    // hkPackfileSectionHeader Signatire: 0xf2a92154 size: 48 flags: FLAGS_NONE

    // m_sectionTag m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 19 offset: 0 flags: FLAGS_NONE enum: 
    // m_nullByte m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 0 offset: 19 flags: FLAGS_NONE enum: 
    // m_absoluteDataStart m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_localFixupsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_globalFixupsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_virtualFixupsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_exportsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_importsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_endOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    public partial class hkPackfileSectionHeader : IHavokObject
    {
        public string m_sectionTag;
        public string m_nullByte;
        public int m_absoluteDataStart;
        public int m_localFixupsOffset;
        public int m_globalFixupsOffset;
        public int m_virtualFixupsOffset;
        public int m_exportsOffset;
        public int m_importsOffset;
        public int m_endOffset;

        public virtual uint Signature => 0xf2a92154;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_sectionTag = br.ReadASCII(19);
            m_nullByte = br.ReadASCII();
            m_absoluteDataStart = br.ReadInt32();
            m_localFixupsOffset = br.ReadInt32();
            m_globalFixupsOffset = br.ReadInt32();
            m_virtualFixupsOffset = br.ReadInt32();
            m_exportsOffset = br.ReadInt32();
            m_importsOffset = br.ReadInt32();
            m_endOffset = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteASCII(m_sectionTag);
            bw.WriteASCII(m_nullByte);
            bw.WriteInt32(m_absoluteDataStart);
            bw.WriteInt32(m_localFixupsOffset);
            bw.WriteInt32(m_globalFixupsOffset);
            bw.WriteInt32(m_virtualFixupsOffset);
            bw.WriteInt32(m_exportsOffset);
            bw.WriteInt32(m_importsOffset);
            bw.WriteInt32(m_endOffset);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_sectionTag), m_sectionTag);
            xs.WriteString(xe, nameof(m_nullByte), m_nullByte);
            xs.WriteNumber(xe, nameof(m_absoluteDataStart), m_absoluteDataStart);
            xs.WriteNumber(xe, nameof(m_localFixupsOffset), m_localFixupsOffset);
            xs.WriteNumber(xe, nameof(m_globalFixupsOffset), m_globalFixupsOffset);
            xs.WriteNumber(xe, nameof(m_virtualFixupsOffset), m_virtualFixupsOffset);
            xs.WriteNumber(xe, nameof(m_exportsOffset), m_exportsOffset);
            xs.WriteNumber(xe, nameof(m_importsOffset), m_importsOffset);
            xs.WriteNumber(xe, nameof(m_endOffset), m_endOffset);
        }
    }
}

