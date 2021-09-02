using System.Collections.Generic;

namespace HKX2
{
    public class hkpStiffSpringChainData : hkpConstraintChainData
    {
        public hkpBridgeAtoms m_atoms;
        public float m_cfm;
        public float m_damping;
        public List<hkpStiffSpringChainDataConstraintInfo> m_infos;
        public float m_tau;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_infos = des.ReadClassArray<hkpStiffSpringChainDataConstraintInfo>(br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_cfm = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
            s.WriteClassArray(bw, m_infos);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_cfm);
            bw.WriteUInt32(0);
        }
    }
}