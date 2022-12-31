using System.Xml.Linq;

namespace HKX2
{
    // hkpCollidable Signatire: 0x9a0e42a5 size: 112 flags: FLAGS_NONE

    // m_ownerOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 32 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_forceCollideOntoPpu m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 33 flags: FLAGS_NONE enum: 
    // m_shapeSizeOnSpu m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 34 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_broadPhaseHandle m_class: hkpTypedBroadPhaseHandle Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_boundingVolumeData m_class: hkpCollidableBoundingVolumeData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_allowedPenetrationDepth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    public partial class hkpCollidable : hkpCdBody
    {
        public sbyte m_ownerOffset;
        public byte m_forceCollideOntoPpu;
        public ushort m_shapeSizeOnSpu;
        public hkpTypedBroadPhaseHandle m_broadPhaseHandle;
        public hkpCollidableBoundingVolumeData m_boundingVolumeData;
        public float m_allowedPenetrationDepth;

        public override uint Signature => 0x9a0e42a5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_ownerOffset = br.ReadSByte();
            m_forceCollideOntoPpu = br.ReadByte();
            m_shapeSizeOnSpu = br.ReadUInt16();
            m_broadPhaseHandle = new hkpTypedBroadPhaseHandle();
            m_broadPhaseHandle.Read(des, br);
            m_boundingVolumeData = new hkpCollidableBoundingVolumeData();
            m_boundingVolumeData.Read(des, br);
            m_allowedPenetrationDepth = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSByte(m_ownerOffset);
            bw.WriteByte(m_forceCollideOntoPpu);
            bw.WriteUInt16(m_shapeSizeOnSpu);
            m_broadPhaseHandle.Write(s, bw);
            m_boundingVolumeData.Write(s, bw);
            bw.WriteSingle(m_allowedPenetrationDepth);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_ownerOffset));
            xs.WriteNumber(xe, nameof(m_forceCollideOntoPpu), m_forceCollideOntoPpu);
            xs.WriteSerializeIgnored(xe, nameof(m_shapeSizeOnSpu));
            xs.WriteClass<hkpTypedBroadPhaseHandle>(xe, nameof(m_broadPhaseHandle), m_broadPhaseHandle);
            xs.WriteSerializeIgnored(xe, nameof(m_boundingVolumeData));
            xs.WriteFloat(xe, nameof(m_allowedPenetrationDepth), m_allowedPenetrationDepth);
        }
    }
}

