using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpPoweredChainData Signatire: 0x38aeafc3 size: 96 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_infos m_class: hkpPoweredChainDataConstraintInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_tau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_cfmLinAdd m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_cfmLinMul m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags: FLAGS_NONE enum: 
    // m_cfmAngAdd m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_cfmAngMul m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_maxErrorDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    public partial class hkpPoweredChainData : hkpConstraintChainData
    {
        public hkpBridgeAtoms m_atoms = new hkpBridgeAtoms();
        public List<hkpPoweredChainDataConstraintInfo> m_infos = new List<hkpPoweredChainDataConstraintInfo>();
        public float m_tau;
        public float m_damping;
        public float m_cfmLinAdd;
        public float m_cfmLinMul;
        public float m_cfmAngAdd;
        public float m_cfmAngMul;
        public float m_maxErrorDistance;

        public override uint Signature => 0x38aeafc3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_infos = des.ReadClassArray<hkpPoweredChainDataConstraintInfo>(br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_cfmLinAdd = br.ReadSingle();
            m_cfmLinMul = br.ReadSingle();
            m_cfmAngAdd = br.ReadSingle();
            m_cfmAngMul = br.ReadSingle();
            m_maxErrorDistance = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_atoms.Write(s, bw);
            s.WriteClassArray<hkpPoweredChainDataConstraintInfo>(bw, m_infos);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_cfmLinAdd);
            bw.WriteSingle(m_cfmLinMul);
            bw.WriteSingle(m_cfmAngAdd);
            bw.WriteSingle(m_cfmAngMul);
            bw.WriteSingle(m_maxErrorDistance);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_atoms = xd.ReadClass<hkpBridgeAtoms>(xe, nameof(m_atoms));
            m_infos = xd.ReadClassArray<hkpPoweredChainDataConstraintInfo>(xe, nameof(m_infos));
            m_tau = xd.ReadSingle(xe, nameof(m_tau));
            m_damping = xd.ReadSingle(xe, nameof(m_damping));
            m_cfmLinAdd = xd.ReadSingle(xe, nameof(m_cfmLinAdd));
            m_cfmLinMul = xd.ReadSingle(xe, nameof(m_cfmLinMul));
            m_cfmAngAdd = xd.ReadSingle(xe, nameof(m_cfmAngAdd));
            m_cfmAngMul = xd.ReadSingle(xe, nameof(m_cfmAngMul));
            m_maxErrorDistance = xd.ReadSingle(xe, nameof(m_maxErrorDistance));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpBridgeAtoms>(xe, nameof(m_atoms), m_atoms);
            xs.WriteClassArray<hkpPoweredChainDataConstraintInfo>(xe, nameof(m_infos), m_infos);
            xs.WriteFloat(xe, nameof(m_tau), m_tau);
            xs.WriteFloat(xe, nameof(m_damping), m_damping);
            xs.WriteFloat(xe, nameof(m_cfmLinAdd), m_cfmLinAdd);
            xs.WriteFloat(xe, nameof(m_cfmLinMul), m_cfmLinMul);
            xs.WriteFloat(xe, nameof(m_cfmAngAdd), m_cfmAngAdd);
            xs.WriteFloat(xe, nameof(m_cfmAngMul), m_cfmAngMul);
            xs.WriteFloat(xe, nameof(m_maxErrorDistance), m_maxErrorDistance);
        }
    }
}

