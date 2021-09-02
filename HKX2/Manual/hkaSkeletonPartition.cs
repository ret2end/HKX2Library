namespace HKX2
{
    public class hkaSkeletonPartition : IHavokObject
    {
        public string m_name;
        public short m_numBones;
        public short m_startBoneIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_startBoneIndex = br.ReadInt16();
            m_numBones = br.ReadInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            bw.WriteInt16(m_startBoneIndex);
            bw.WriteInt16(m_numBones);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}