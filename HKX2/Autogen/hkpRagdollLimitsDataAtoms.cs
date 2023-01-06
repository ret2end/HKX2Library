using System.Xml.Linq;

namespace HKX2
{
    // hkpRagdollLimitsDataAtoms Signatire: 0x82b894c3 size: 176 flags: FLAGS_NONE

    // m_rotations m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_twistLimit m_class: hkpTwistLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_coneLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 132 flags: FLAGS_NONE enum: 
    // m_planesLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    public partial class hkpRagdollLimitsDataAtoms : IHavokObject
    {
        public hkpSetLocalRotationsConstraintAtom m_rotations = new hkpSetLocalRotationsConstraintAtom();
        public hkpTwistLimitConstraintAtom m_twistLimit = new hkpTwistLimitConstraintAtom();
        public hkpConeLimitConstraintAtom m_coneLimit = new hkpConeLimitConstraintAtom();
        public hkpConeLimitConstraintAtom m_planesLimit = new hkpConeLimitConstraintAtom();

        public virtual uint Signature => 0x82b894c3;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des, br);
            m_twistLimit = new hkpTwistLimitConstraintAtom();
            m_twistLimit.Read(des, br);
            m_coneLimit = new hkpConeLimitConstraintAtom();
            m_coneLimit.Read(des, br);
            m_planesLimit = new hkpConeLimitConstraintAtom();
            m_planesLimit.Read(des, br);
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_rotations.Write(s, bw);
            m_twistLimit.Write(s, bw);
            m_coneLimit.Write(s, bw);
            m_planesLimit.Write(s, bw);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_rotations = xd.ReadClass<hkpSetLocalRotationsConstraintAtom>(xe, nameof(m_rotations));
            m_twistLimit = xd.ReadClass<hkpTwistLimitConstraintAtom>(xe, nameof(m_twistLimit));
            m_coneLimit = xd.ReadClass<hkpConeLimitConstraintAtom>(xe, nameof(m_coneLimit));
            m_planesLimit = xd.ReadClass<hkpConeLimitConstraintAtom>(xe, nameof(m_planesLimit));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalRotationsConstraintAtom>(xe, nameof(m_rotations), m_rotations);
            xs.WriteClass<hkpTwistLimitConstraintAtom>(xe, nameof(m_twistLimit), m_twistLimit);
            xs.WriteClass<hkpConeLimitConstraintAtom>(xe, nameof(m_coneLimit), m_coneLimit);
            xs.WriteClass<hkpConeLimitConstraintAtom>(xe, nameof(m_planesLimit), m_planesLimit);
        }
    }
}

