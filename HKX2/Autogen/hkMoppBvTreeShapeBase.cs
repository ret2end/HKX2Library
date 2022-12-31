using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkMoppBvTreeShapeBase Signatire: 0x7c338c66 size: 80 flags: FLAGS_NONE

    // m_code m_class: hkpMoppCode Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_moppData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_moppDataSize m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_codeInfoCopy m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkMoppBvTreeShapeBase : hkpBvTreeShape
    {
        public hkpMoppCode m_code;
        public dynamic m_moppData;
        public uint m_moppDataSize;
        public Vector4 m_codeInfoCopy;

        public override uint Signature => 0x7c338c66;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_code = des.ReadClassPointer<hkpMoppCode>(br);
            des.ReadEmptyPointer(br);
            m_moppDataSize = br.ReadUInt32();
            br.Position += 4;
            m_codeInfoCopy = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_code);
            s.WriteVoidPointer(bw);
            bw.WriteUInt32(m_moppDataSize);
            bw.Position += 4;
            bw.WriteVector4(m_codeInfoCopy);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_code), m_code);
            xs.WriteSerializeIgnored(xe, nameof(m_moppData));
            xs.WriteSerializeIgnored(xe, nameof(m_moppDataSize));
            xs.WriteSerializeIgnored(xe, nameof(m_codeInfoCopy));
        }
    }
}

