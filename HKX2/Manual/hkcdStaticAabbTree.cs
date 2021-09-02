namespace HKX2
{
    public class hkcdStaticAabbTree : hkReferencedObject
    {
        public hkcdStaticTreeDefaultTreeStorage6 m_treePtr;
        public override uint Signature => 0x99E8D0CB;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            br.ReadBoolean(); // shouldDeleteTree
            br.ReadByte();
            br.ReadUInt16();

            m_treePtr = des.ReadClassPointer<hkcdStaticTreeDefaultTreeStorage6>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteBoolean(false); // shouldDeleteTree
            bw.WriteByte(0);
            bw.WriteUInt16(0);

            s.WriteClassPointer(bw, m_treePtr);
        }
    }
}