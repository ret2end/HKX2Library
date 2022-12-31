using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCollisionFilter Signatire: 0x60960336 size: 72 flags: FLAGS_NONE

    // m_prepad m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 2 offset: 48 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT32 arrSize: 0 offset: 56 flags: FLAGS_NONE enum: hkpFilterType
    // m_postpad m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 60 flags: FLAGS_NONE enum: 
    public partial class hkpCollisionFilter : hkReferencedObject
    {
        public List<uint> m_prepad;
        public uint m_type;
        public List<uint> m_postpad;

        public override uint Signature => 0x60960336;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 32;
            m_prepad = des.ReadUInt32CStyleArray(br, 2);
            m_type = br.ReadUInt32();
            m_postpad = des.ReadUInt32CStyleArray(br, 3);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 32;
            s.WriteUInt32CStyleArray(bw, m_prepad);
            s.WriteUInt32(bw, m_type);
            s.WriteUInt32CStyleArray(bw, m_postpad);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_prepad), m_prepad);
            xs.WriteEnum<hkpFilterType, uint>(xe, nameof(m_type), m_type);
            xs.WriteNumberArray(xe, nameof(m_postpad), m_postpad);
        }
    }
}

