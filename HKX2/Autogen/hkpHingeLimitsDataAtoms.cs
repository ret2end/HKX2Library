using System.Xml.Linq;

namespace HKX2
{
    // hkpHingeLimitsDataAtoms Signatire: 0x555876ff size: 144 flags: FLAGS_NONE

    // m_rotations m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_angLimit m_class: hkpAngLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    public partial class hkpHingeLimitsDataAtoms : IHavokObject
    {
        public hkpSetLocalRotationsConstraintAtom m_rotations = new hkpSetLocalRotationsConstraintAtom();
        public hkpAngLimitConstraintAtom m_angLimit = new hkpAngLimitConstraintAtom();
        public hkp2dAngConstraintAtom m_2dAng = new hkp2dAngConstraintAtom();

        public virtual uint Signature => 0x555876ff;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des, br);
            m_angLimit = new hkpAngLimitConstraintAtom();
            m_angLimit.Read(des, br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des, br);
            br.Position += 12;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_rotations.Write(s, bw);
            m_angLimit.Write(s, bw);
            m_2dAng.Write(s, bw);
            bw.Position += 12;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_rotations = xd.ReadClass<hkpSetLocalRotationsConstraintAtom>(xe, nameof(m_rotations));
            m_angLimit = xd.ReadClass<hkpAngLimitConstraintAtom>(xe, nameof(m_angLimit));
            m_2dAng = xd.ReadClass<hkp2dAngConstraintAtom>(xe, nameof(m_2dAng));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalRotationsConstraintAtom>(xe, nameof(m_rotations), m_rotations);
            xs.WriteClass<hkpAngLimitConstraintAtom>(xe, nameof(m_angLimit), m_angLimit);
            xs.WriteClass<hkp2dAngConstraintAtom>(xe, nameof(m_2dAng), m_2dAng);
        }
    }
}

