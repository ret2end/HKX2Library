using System.Xml.Linq;

namespace HKX2
{
    // hkpConstraintChainInstanceAction Signatire: 0xc3971189 size: 56 flags: FLAGS_NONE

    // m_constraintInstance m_class: hkpConstraintChainInstance Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: NOT_OWNED|FLAGS_NONE enum: 
    public partial class hkpConstraintChainInstanceAction : hkpAction
    {
        public hkpConstraintChainInstance m_constraintInstance;

        public override uint Signature => 0xc3971189;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_constraintInstance = des.ReadClassPointer<hkpConstraintChainInstance>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintInstance);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_constraintInstance = xd.ReadClassPointer<hkpConstraintChainInstance>(xe, nameof(m_constraintInstance));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_constraintInstance), m_constraintInstance);
        }
    }
}

