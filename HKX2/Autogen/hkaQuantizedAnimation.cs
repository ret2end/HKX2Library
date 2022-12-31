using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaQuantizedAnimation Signatire: 0x3920f053 size: 88 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_endian m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_skeleton m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 80 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkaQuantizedAnimation : hkaAnimation
    {
        public List<byte> m_data;
        public uint m_endian;
        public dynamic m_skeleton;

        public override uint Signature => 0x3920f053;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_data = des.ReadByteArray(br);
            m_endian = br.ReadUInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteByteArray(bw, m_data);
            bw.WriteUInt32(m_endian);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
            xs.WriteNumber(xe, nameof(m_endian), m_endian);
            xs.WriteSerializeIgnored(xe, nameof(m_skeleton));
        }
    }
}

