using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpRackAndPinionConstraintData Signatire: 0xd180ebe0 size: 192 flags: FLAGS_NONE

    // m_atoms m_class: hkpRackAndPinionConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpRackAndPinionConstraintData : hkpConstraintData
    {
        public hkpRackAndPinionConstraintDataAtoms m_atoms { set; get; } = new();

        public override uint Signature => 0xd180ebe0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_atoms.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            m_atoms.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_atoms = xd.ReadClass<hkpRackAndPinionConstraintDataAtoms>(xe, nameof(m_atoms));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpRackAndPinionConstraintDataAtoms>(xe, nameof(m_atoms), m_atoms);
        }
    }
}

