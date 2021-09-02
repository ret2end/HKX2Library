namespace HKX2
{
    public class hkcdStaticTreeTreehkcdStaticTreeDynamicStorage5 : hkcdStaticTreeDynamicStorage5
    {
        public hkAabb m_domain;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_domain = new hkAabb();
            m_domain.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_domain.Write(s, bw);
        }
    }
}