using System.Xml.Linq;

namespace HKX2
{
    // hkpCallbackConstraintMotor Signatire: 0xafcd79ad size: 72 flags: FLAGS_NONE

    // m_callbackFunc m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 32 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_callbackType m_class:  Type.TYPE_ENUM Type.TYPE_UINT32 arrSize: 0 offset: 40 flags: FLAGS_NONE enum: CallbackType
    // m_userData0 m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_userData1 m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_userData2 m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpCallbackConstraintMotor : hkpLimitedForceConstraintMotor
    {
        public dynamic m_callbackFunc;
        public uint m_callbackType;
        public ulong m_userData0;
        public ulong m_userData1;
        public ulong m_userData2;

        public override uint Signature => 0xafcd79ad;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyPointer(br);
            m_callbackType = br.ReadUInt32();
            br.Position += 4;
            m_userData0 = br.ReadUInt64();
            m_userData1 = br.ReadUInt64();
            m_userData2 = br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidPointer(bw);
            s.WriteUInt32(bw, m_callbackType);
            bw.Position += 4;
            bw.WriteUInt64(m_userData0);
            bw.WriteUInt64(m_userData1);
            bw.WriteUInt64(m_userData2);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_callbackFunc = default;
            m_callbackType = xd.ReadFlag<CallbackType, uint>(xe, nameof(m_callbackType));
            m_userData0 = xd.ReadUInt64(xe, nameof(m_userData0));
            m_userData1 = xd.ReadUInt64(xe, nameof(m_userData1));
            m_userData2 = xd.ReadUInt64(xe, nameof(m_userData2));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_callbackFunc));
            xs.WriteEnum<CallbackType, uint>(xe, nameof(m_callbackType), m_callbackType);
            xs.WriteNumber(xe, nameof(m_userData0), m_userData0);
            xs.WriteNumber(xe, nameof(m_userData1), m_userData1);
            xs.WriteNumber(xe, nameof(m_userData2), m_userData2);
        }
    }
}

