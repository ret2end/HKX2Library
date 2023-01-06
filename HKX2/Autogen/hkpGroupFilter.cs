using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpGroupFilter Signatire: 0x65ee88e4 size: 272 flags: FLAGS_NONE

    // m_nextFreeSystemGroup m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_collisionLookupTable m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 32 offset: 76 flags: FLAGS_NONE enum: 
    // m_pad256 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 4 offset: 208 flags: FLAGS_NONE enum: 
    public partial class hkpGroupFilter : hkpCollisionFilter
    {
        public int m_nextFreeSystemGroup;
        public uint[] m_collisionLookupTable = new uint[32];
        public Vector4[] m_pad256 = new Vector4[4];

        public override uint Signature => 0x65ee88e4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nextFreeSystemGroup = br.ReadInt32();
            m_collisionLookupTable = des.ReadUInt32CStyleArray(br, 32);
            br.Position += 4;
            m_pad256 = des.ReadVector4CStyleArray(br, 4);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_nextFreeSystemGroup);
            s.WriteUInt32CStyleArray(bw, m_collisionLookupTable);
            bw.Position += 4;
            s.WriteVector4CStyleArray(bw, m_pad256);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_nextFreeSystemGroup = xd.ReadInt32(xe, nameof(m_nextFreeSystemGroup));
            m_collisionLookupTable = xd.ReadUInt32CStyleArray(xe, nameof(m_collisionLookupTable), 32);
            m_pad256 = xd.ReadVector4CStyleArray(xe, nameof(m_pad256), 4);
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_nextFreeSystemGroup), m_nextFreeSystemGroup);
            xs.WriteNumberArray(xe, nameof(m_collisionLookupTable), m_collisionLookupTable);
            xs.WriteVector4Array(xe, nameof(m_pad256), m_pad256);
        }
    }
}

