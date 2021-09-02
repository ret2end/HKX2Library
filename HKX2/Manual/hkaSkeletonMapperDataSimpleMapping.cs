using System.Numerics;

namespace HKX2
{
    public class hkaSkeletonMapperDataSimpleMapping : IHavokObject
    {
        public Matrix4x4 m_aFromBTransform;

        public short m_boneA;
        public short m_boneB;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_boneA = br.ReadInt16();
            m_boneB = br.ReadInt16();
            br.Pad(16);
            m_aFromBTransform = des.ReadQSTransform(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt16(m_boneA);
            bw.WriteInt16(m_boneB);
            bw.Pad(16);
            s.WriteQSTransform(bw, m_aFromBTransform);
        }
    }
}