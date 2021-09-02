namespace HKX2
{
    public class hkcdDynamicAabbTree : hkReferencedObject
    {
        public hkcdDynamicTreeDefaultTree48Storage m_treePtr;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_treePtr = des.ReadClassPointer<hkcdDynamicTreeDefaultTree48Storage>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_treePtr);
        }
    }
}