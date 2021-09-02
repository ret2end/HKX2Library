using System.Numerics;

namespace HKX2
{
    public class hkpSerializedDisplayRbTransformsDisplayTransformPair : IHavokObject
    {
        public Matrix4x4 m_localToDisplay;

        public hkpRigidBody m_rb;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rb = des.ReadClassPointer<hkpRigidBody>(br);
            br.ReadUInt64();
            m_localToDisplay = des.ReadTransform(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_rb);
            bw.WriteUInt64(0);
            s.WriteTransform(bw, m_localToDisplay);
        }
    }
}