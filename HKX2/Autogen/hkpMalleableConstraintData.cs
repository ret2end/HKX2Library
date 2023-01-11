using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMalleableConstraintData Signatire: 0x6748b2cf size: 64 flags: FLAGS_NONE

    // m_constraintData m_class: hkpConstraintData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    public partial class hkpMalleableConstraintData : hkpConstraintData
    {
        public hkpConstraintData? m_constraintData { set; get; } = default;
        public hkpBridgeAtoms m_atoms { set; get; } = new();
        public float m_strength { set; get; } = default;

        public override uint Signature => 0x6748b2cf;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);
            m_atoms.Read(des, br);
            m_strength = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintData);
            m_atoms.Write(s, bw);
            bw.WriteSingle(m_strength);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_constraintData = xd.ReadClassPointer<hkpConstraintData>(xe, nameof(m_constraintData));
            m_atoms = xd.ReadClass<hkpBridgeAtoms>(xe, nameof(m_atoms));
            m_strength = xd.ReadSingle(xe, nameof(m_strength));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_constraintData), m_constraintData);
            xs.WriteClass<hkpBridgeAtoms>(xe, nameof(m_atoms), m_atoms);
            xs.WriteFloat(xe, nameof(m_strength), m_strength);
        }
    }
}

