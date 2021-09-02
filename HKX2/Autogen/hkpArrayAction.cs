using System.Collections.Generic;

namespace HKX2
{
    public class hkpArrayAction : hkpAction
    {
        public List<hkpEntity> m_entities;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_entities = des.ReadClassPointerArray<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_entities);
        }
    }
}