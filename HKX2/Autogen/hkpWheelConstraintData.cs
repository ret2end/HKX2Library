using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpWheelConstraintData Signatire: 0xb4c46671 size: 368 flags: FLAGS_NONE

    // m_atoms m_class: hkpWheelConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_initialAxleInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 336 flags: FLAGS_NONE enum: 
    // m_initialSteeringAxisInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 352 flags: FLAGS_NONE enum: 
    public partial class hkpWheelConstraintData : hkpConstraintData
    {
        public hkpWheelConstraintDataAtoms m_atoms;
        public Vector4 m_initialAxleInB;
        public Vector4 m_initialSteeringAxisInB;

        public override uint Signature => 0xb4c46671;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpWheelConstraintDataAtoms();
            m_atoms.Read(des, br);
            m_initialAxleInB = br.ReadVector4();
            m_initialSteeringAxisInB = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            m_atoms.Write(s, bw);
            bw.WriteVector4(m_initialAxleInB);
            bw.WriteVector4(m_initialSteeringAxisInB);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpWheelConstraintDataAtoms>(xe, nameof(m_atoms), m_atoms);
            xs.WriteVector4(xe, nameof(m_initialAxleInB), m_initialAxleInB);
            xs.WriteVector4(xe, nameof(m_initialSteeringAxisInB), m_initialSteeringAxisInB);
        }
    }
}

