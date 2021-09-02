namespace HKX2
{
    public class hkaSkeletonLocalFrameOnBone : IHavokObject
    {
        public short m_boneIndex;

        public hkLocalFrame m_localFrame;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_localFrame = des.ReadClassPointer<hkLocalFrame>(br);
            m_boneIndex = br.ReadInt16();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_localFrame);
            bw.WriteInt16(m_boneIndex);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}