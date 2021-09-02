using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpBallSocketChainData : hkpConstraintChainData
    {
        public hkpBridgeAtoms m_atoms;
        public float m_cfm;
        public float m_damping;
        public float m_inertiaPerMeter;
        public List<hkpBallSocketChainDataConstraintInfo> m_infos;
        public Vector4 m_link0PivotBVelocity;
        public float m_maxErrorDistance;
        public float m_tau;
        public bool m_useStabilizedCode;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_infos = des.ReadClassArray<hkpBallSocketChainDataConstraintInfo>(br);
            m_link0PivotBVelocity = des.ReadVector4(br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_cfm = br.ReadSingle();
            m_maxErrorDistance = br.ReadSingle();
            m_inertiaPerMeter = br.ReadSingle();
            m_useStabilizedCode = br.ReadBoolean();
            br.ReadUInt64();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
            s.WriteClassArray(bw, m_infos);
            s.WriteVector4(bw, m_link0PivotBVelocity);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_cfm);
            bw.WriteSingle(m_maxErrorDistance);
            bw.WriteSingle(m_inertiaPerMeter);
            bw.WriteBoolean(m_useStabilizedCode);
            bw.WriteUInt64(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}