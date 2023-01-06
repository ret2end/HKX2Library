using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMoppCode Signatire: 0x924c2661 size: 64 flags: FLAGS_NONE

    // m_info m_class: hkpMoppCodeCodeInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_buildType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: BuildType
    public partial class hkpMoppCode : hkReferencedObject
    {
        public hkpMoppCodeCodeInfo m_info = new hkpMoppCodeCodeInfo();
        public List<byte> m_data;
        public sbyte m_buildType;

        public override uint Signature => 0x924c2661;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_info = new hkpMoppCodeCodeInfo();
            m_info.Read(des, br);
            m_data = des.ReadByteArray(br);
            m_buildType = br.ReadSByte();
            br.Position += 15;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_info.Write(s, bw);
            s.WriteByteArray(bw, m_data);
            s.WriteSByte(bw, m_buildType);
            bw.Position += 15;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_info = xd.ReadClass<hkpMoppCodeCodeInfo>(xe, nameof(m_info));
            m_data = xd.ReadByteArray(xe, nameof(m_data));
            m_buildType = xd.ReadFlag<BuildType, sbyte>(xe, nameof(m_buildType));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpMoppCodeCodeInfo>(xe, nameof(m_info), m_info);
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
            xs.WriteEnum<BuildType, sbyte>(xe, nameof(m_buildType), m_buildType);
        }
    }
}

