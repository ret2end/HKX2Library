using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSerializedAgentNnEntry Signatire: 0x49ec7de3 size: 368 flags: FLAGS_NONE

    // m_bodyA m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_bodyB m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_bodyAId m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_bodyBId m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_useEntityIds m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_agentType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 49 flags: FLAGS_NONE enum: SerializedAgentType
    // m_atom m_class: hkpSimpleContactConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_propertiesStream m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_contactPoints m_class: hkContactPoint Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_cpIdMgr m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_nnEntryData m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 160 offset: 160 flags: FLAGS_NONE enum: 
    // m_trackInfo m_class: hkpSerializedTrack1nInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 320 flags: FLAGS_NONE enum: 
    // m_endianCheckBuffer m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 4 offset: 352 flags: FLAGS_NONE enum: 
    // m_version m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 356 flags: FLAGS_NONE enum: 
    public partial class hkpSerializedAgentNnEntry : hkReferencedObject
    {
        public hkpEntity m_bodyA;
        public hkpEntity m_bodyB;
        public ulong m_bodyAId;
        public ulong m_bodyBId;
        public bool m_useEntityIds;
        public sbyte m_agentType;
        public hkpSimpleContactConstraintAtom m_atom;
        public List<byte> m_propertiesStream;
        public List<hkContactPoint> m_contactPoints;
        public List<byte> m_cpIdMgr;
        public List<byte> m_nnEntryData;
        public hkpSerializedTrack1nInfo m_trackInfo;
        public List<byte> m_endianCheckBuffer;
        public uint m_version;

        public override uint Signature => 0x49ec7de3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bodyA = des.ReadClassPointer<hkpEntity>(br);
            m_bodyB = des.ReadClassPointer<hkpEntity>(br);
            m_bodyAId = br.ReadUInt64();
            m_bodyBId = br.ReadUInt64();
            m_useEntityIds = br.ReadBoolean();
            m_agentType = br.ReadSByte();
            br.Position += 14;
            m_atom = new hkpSimpleContactConstraintAtom();
            m_atom.Read(des, br);
            m_propertiesStream = des.ReadByteArray(br);
            m_contactPoints = des.ReadClassArray<hkContactPoint>(br);
            m_cpIdMgr = des.ReadByteArray(br);
            m_nnEntryData = des.ReadByteCStyleArray(br, 160);
            m_trackInfo = new hkpSerializedTrack1nInfo();
            m_trackInfo.Read(des, br);
            m_endianCheckBuffer = des.ReadByteCStyleArray(br, 4);
            m_version = br.ReadUInt32();
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_bodyA);
            s.WriteClassPointer(bw, m_bodyB);
            bw.WriteUInt64(m_bodyAId);
            bw.WriteUInt64(m_bodyBId);
            bw.WriteBoolean(m_useEntityIds);
            s.WriteSByte(bw, m_agentType);
            bw.Position += 14;
            m_atom.Write(s, bw);
            s.WriteByteArray(bw, m_propertiesStream);
            s.WriteClassArray<hkContactPoint>(bw, m_contactPoints);
            s.WriteByteArray(bw, m_cpIdMgr);
            s.WriteByteCStyleArray(bw, m_nnEntryData);
            m_trackInfo.Write(s, bw);
            s.WriteByteCStyleArray(bw, m_endianCheckBuffer);
            bw.WriteUInt32(m_version);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_bodyA), m_bodyA);
            xs.WriteClassPointer(xe, nameof(m_bodyB), m_bodyB);
            xs.WriteNumber(xe, nameof(m_bodyAId), m_bodyAId);
            xs.WriteNumber(xe, nameof(m_bodyBId), m_bodyBId);
            xs.WriteBoolean(xe, nameof(m_useEntityIds), m_useEntityIds);
            xs.WriteEnum<SerializedAgentType, sbyte>(xe, nameof(m_agentType), m_agentType);
            xs.WriteClass<hkpSimpleContactConstraintAtom>(xe, nameof(m_atom), m_atom);
            xs.WriteNumberArray(xe, nameof(m_propertiesStream), m_propertiesStream);
            xs.WriteClassArray<hkContactPoint>(xe, nameof(m_contactPoints), m_contactPoints);
            xs.WriteNumberArray(xe, nameof(m_cpIdMgr), m_cpIdMgr);
            xs.WriteNumberArray(xe, nameof(m_nnEntryData), m_nnEntryData);
            xs.WriteClass<hkpSerializedTrack1nInfo>(xe, nameof(m_trackInfo), m_trackInfo);
            xs.WriteNumberArray(xe, nameof(m_endianCheckBuffer), m_endianCheckBuffer);
            xs.WriteNumber(xe, nameof(m_version), m_version);
        }
    }
}

