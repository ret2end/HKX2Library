using System.Xml.Linq;

namespace HKX2
{
    // hkbGetUpModifierInternalState Signatire: 0xd84cad4a size: 32 flags: FLAGS_NONE

    // m_timeSinceBegin m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_initNextModify m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbGetUpModifierInternalState : hkReferencedObject
    {
        public float m_timeSinceBegin;
        public float m_timeStep;
        public bool m_initNextModify;

        public override uint Signature => 0xd84cad4a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_timeSinceBegin = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            m_initNextModify = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_timeSinceBegin);
            bw.WriteSingle(m_timeStep);
            bw.WriteBoolean(m_initNextModify);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_timeSinceBegin), m_timeSinceBegin);
            xs.WriteFloat(xe, nameof(m_timeStep), m_timeStep);
            xs.WriteBoolean(xe, nameof(m_initNextModify), m_initNextModify);
        }
    }
}

