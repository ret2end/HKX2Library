using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpStiffSpringChainData Signatire: 0xf170356b size: 80 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_infos m_class: hkpStiffSpringChainDataConstraintInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_cfm m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    
    public class hkpStiffSpringChainData : hkpConstraintChainData
    {

        public hkpBridgeAtoms/*struct void*/ m_atoms;
        public List<hkpStiffSpringChainDataConstraintInfo> m_infos;
        public float m_tau;
        public float m_damping;
        public float m_cfm;

        public override uint Signature => 0xf170356b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des,br);
            m_infos = des.ReadClassArray<hkpStiffSpringChainDataConstraintInfo>(br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_cfm = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_atoms.Write(s, bw);
            s.WriteClassArray<hkpStiffSpringChainDataConstraintInfo>(bw, m_infos);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_cfm);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

