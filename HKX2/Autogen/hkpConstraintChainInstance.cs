using System.Collections.Generic;

namespace HKX2
{
    public class hkpConstraintChainInstance : hkpConstraintInstance
    {
        public hkpConstraintChainInstanceAction m_action;
        public ulong m_chainConnectedness;

        public List<hkpEntity> m_chainedEntities;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_chainedEntities = des.ReadClassPointerArray<hkpEntity>(br);
            m_action = des.ReadClassPointer<hkpConstraintChainInstanceAction>(br);
            m_chainConnectedness = br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_chainedEntities);
            s.WriteClassPointer(bw, m_action);
            bw.WriteUInt64(m_chainConnectedness);
        }
    }
}