using System.Collections.Generic;

namespace HKX2
{
    public class hkpDisableEntityCollisionFilter : hkpCollisionFilter
    {
        public List<hkpEntity> m_disabledEntities;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_disabledEntities = des.ReadClassPointerArray<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteClassPointerArray(bw, m_disabledEntities);
        }
    }
}