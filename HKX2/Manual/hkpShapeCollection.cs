namespace HKX2
{
    public enum CollectionType
    {
        COLLECTION_LIST = 0,
        COLLECTION_EXTENDED_MESH = 1,
        COLLECTION_TRISAMPLED_HEIGHTFIELD = 2,
        COLLECTION_USER = 3,
        COLLECTION_SIMPLE_MESH = 4,
        COLLECTION_MESH_SHAPE = 5,
        COLLECTION_COMPRESSED_MESH = 6,
        COLLECTION_MAX = 7
    }

    public class hkpShapeCollection : hkpShape
    {
        public CollectionType m_collectionType;

        public bool m_disableWelding;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.AssertUSize(0);
            m_disableWelding = br.ReadBoolean();
            m_collectionType = (CollectionType) br.ReadByte();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUSize(0);
            bw.WriteBoolean(m_disableWelding);
            bw.WriteByte((byte) m_collectionType);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}