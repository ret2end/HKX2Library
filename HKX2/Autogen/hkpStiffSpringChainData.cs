using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpStiffSpringChainData Signatire: 0xf170356b size: 80 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_infos m_class: hkpStiffSpringChainDataConstraintInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_cfm m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    public partial class hkpStiffSpringChainData : hkpConstraintChainData
    {
        public hkpBridgeAtoms m_atoms;
        public List<hkpStiffSpringChainDataConstraintInfo> m_infos;
        public float m_tau;
        public float m_damping;
        public float m_cfm;

        public override uint Signature => 0xf170356b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_infos = des.ReadClassArray<hkpStiffSpringChainDataConstraintInfo>(br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_cfm = br.ReadSingle();
            br.Position += 4;
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpBridgeAtoms>(xe, nameof(m_atoms), m_atoms);
            xs.WriteClassArray<hkpStiffSpringChainDataConstraintInfo>(xe, nameof(m_infos), m_infos);
            xs.WriteFloat(xe, nameof(m_tau), m_tau);
            xs.WriteFloat(xe, nameof(m_damping), m_damping);
            xs.WriteFloat(xe, nameof(m_cfm), m_cfm);
        }
    }
}

