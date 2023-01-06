using System.Xml.Linq;

namespace HKX2
{
    // BSGetTimeStepModifier Signatire: 0xbda33bfe size: 88 flags: FLAGS_NONE

    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class BSGetTimeStepModifier : hkbModifier
    {
        public float m_timeStep;

        public override uint Signature => 0xbda33bfe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_timeStep = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_timeStep);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_timeStep = xd.ReadSingle(xe, nameof(m_timeStep));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_timeStep), m_timeStep);
        }
    }
}

