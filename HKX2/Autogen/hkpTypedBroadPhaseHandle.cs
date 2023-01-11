using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpTypedBroadPhaseHandle Signatire: 0xf4b0f799 size: 12 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_ownerOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 5 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_objectQualityType m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 6 flags: FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpTypedBroadPhaseHandle : hkpBroadPhaseHandle
    {
        public sbyte m_type { set; get; } = default;
        private sbyte m_ownerOffset { set; get; } = default;
        public sbyte m_objectQualityType { set; get; } = default;
        public uint m_collisionFilterInfo { set; get; } = default;

        public override uint Signature => 0xf4b0f799;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = br.ReadSByte();
            m_ownerOffset = br.ReadSByte();
            m_objectQualityType = br.ReadSByte();
            br.Position += 1;
            m_collisionFilterInfo = br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSByte(m_type);
            bw.WriteSByte(m_ownerOffset);
            bw.WriteSByte(m_objectQualityType);
            bw.Position += 1;
            bw.WriteUInt32(m_collisionFilterInfo);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_type = xd.ReadSByte(xe, nameof(m_type));
            m_objectQualityType = xd.ReadSByte(xe, nameof(m_objectQualityType));
            m_collisionFilterInfo = xd.ReadUInt32(xe, nameof(m_collisionFilterInfo));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_type), m_type);
            xs.WriteSerializeIgnored(xe, nameof(m_ownerOffset));
            xs.WriteNumber(xe, nameof(m_objectQualityType), m_objectQualityType);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
        }
    }
}

