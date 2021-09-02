namespace HKX2
{
    public class hkpSimpleShapePhantomCollisionDetail : IHavokObject
    {
        public hkpCollidable m_collidable;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_collidable = des.ReadClassPointer<hkpCollidable>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_collidable);
        }
    }
}