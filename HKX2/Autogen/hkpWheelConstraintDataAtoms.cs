using System.Xml.Linq;

namespace HKX2
{
    // hkpWheelConstraintDataAtoms Signatire: 0x1188cbe1 size: 304 flags: FLAGS_NONE

    // m_suspensionBase m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_lin0Limit m_class: hkpLinLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_lin0Soft m_class: hkpLinSoftConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 156 flags: FLAGS_NONE enum: 
    // m_lin1 m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    // m_lin2 m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 172 flags: FLAGS_NONE enum: 
    // m_steeringBase m_class: hkpSetLocalRotationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 288 flags: FLAGS_NONE enum: 
    public partial class hkpWheelConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTransformsConstraintAtom m_suspensionBase;
        public hkpLinLimitConstraintAtom m_lin0Limit;
        public hkpLinSoftConstraintAtom m_lin0Soft;
        public hkpLinConstraintAtom m_lin1;
        public hkpLinConstraintAtom m_lin2;
        public hkpSetLocalRotationsConstraintAtom m_steeringBase;
        public hkp2dAngConstraintAtom m_2dAng;

        public virtual uint Signature => 0x1188cbe1;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_suspensionBase = new hkpSetLocalTransformsConstraintAtom();
            m_suspensionBase.Read(des, br);
            m_lin0Limit = new hkpLinLimitConstraintAtom();
            m_lin0Limit.Read(des, br);
            m_lin0Soft = new hkpLinSoftConstraintAtom();
            m_lin0Soft.Read(des, br);
            m_lin1 = new hkpLinConstraintAtom();
            m_lin1.Read(des, br);
            m_lin2 = new hkpLinConstraintAtom();
            m_lin2.Read(des, br);
            m_steeringBase = new hkpSetLocalRotationsConstraintAtom();
            m_steeringBase.Read(des, br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des, br);
            br.Position += 12;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_suspensionBase.Write(s, bw);
            m_lin0Limit.Write(s, bw);
            m_lin0Soft.Write(s, bw);
            m_lin1.Write(s, bw);
            m_lin2.Write(s, bw);
            m_steeringBase.Write(s, bw);
            m_2dAng.Write(s, bw);
            bw.Position += 12;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTransformsConstraintAtom>(xe, nameof(m_suspensionBase), m_suspensionBase);
            xs.WriteClass<hkpLinLimitConstraintAtom>(xe, nameof(m_lin0Limit), m_lin0Limit);
            xs.WriteClass<hkpLinSoftConstraintAtom>(xe, nameof(m_lin0Soft), m_lin0Soft);
            xs.WriteClass<hkpLinConstraintAtom>(xe, nameof(m_lin1), m_lin1);
            xs.WriteClass<hkpLinConstraintAtom>(xe, nameof(m_lin2), m_lin2);
            xs.WriteClass<hkpSetLocalRotationsConstraintAtom>(xe, nameof(m_steeringBase), m_steeringBase);
            xs.WriteClass<hkp2dAngConstraintAtom>(xe, nameof(m_2dAng), m_2dAng);
        }
    }
}

