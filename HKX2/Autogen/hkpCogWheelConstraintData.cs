using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCogWheelConstraintData Signatire: 0x7f0e53fc size: 192 flags: FLAGS_NONE

    // m_atoms m_class: hkpCogWheelConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpCogWheelConstraintData : hkpConstraintData, IEquatable<hkpCogWheelConstraintData?>
    {
        public hkpCogWheelConstraintDataAtoms m_atoms { set; get; } = new();

        public override uint Signature { set; get; } = 0x7f0e53fc;

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
            m_atoms = xd.ReadClass<hkpCogWheelConstraintDataAtoms>(xe, nameof(m_atoms));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpCogWheelConstraintDataAtoms>(xe, nameof(m_atoms), m_atoms);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as hkpCogWheelConstraintData);
        }

        public bool Equals(hkpCogWheelConstraintData? other)
        {
            return other is not null &&
                   base.Equals(other) &&
                   ((m_atoms is null && other.m_atoms is null) || (m_atoms is not null && other.m_atoms is not null && m_atoms.Equals((IHavokObject)other.m_atoms))) &&
                   Signature == other.Signature; ;
        }

        public override int GetHashCode()
        {
            var hashcode = new HashCode();
            hashcode.Add(base.GetHashCode());
            hashcode.Add(m_atoms);
            hashcode.Add(Signature);
            return hashcode.ToHashCode();
        }
    }
}

