using System.Collections.Generic;

namespace HKX2
{
    public class hkpWorldObject : hkReferencedObject
    {
        public hkpLinkedCollidable m_collidable;
        public hkMultiThreadCheck m_multiThreadCheck;
        public string m_name;
        public List<hkSimpleProperty> m_properties;

        public ulong m_userData;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyPointer(br);
            m_userData = br.ReadUSize();
            m_collidable = new hkpLinkedCollidable();
            m_collidable.Read(des, br);
            m_multiThreadCheck = new hkMultiThreadCheck();
            m_multiThreadCheck.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_properties = des.ReadClassArray<hkSimpleProperty>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidPointer(bw);
            bw.WriteUSize(m_userData);
            m_collidable.Write(s, bw);
            m_multiThreadCheck.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray(bw, m_properties);
        }
    }
}