using System.Xml.Linq;

namespace HKX2
{
    // hkbPoseMatchingGeneratorInternalState Signatire: 0x552d9dd4 size: 40 flags: FLAGS_NONE

    // m_currentMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_bestMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_timeSinceBetterMatch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_error m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_resetCurrentMatchLocalTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbPoseMatchingGeneratorInternalState : hkReferencedObject
    {
        public int m_currentMatch;
        public int m_bestMatch;
        public float m_timeSinceBetterMatch;
        public float m_error;
        public bool m_resetCurrentMatchLocalTime;

        public override uint Signature => 0x552d9dd4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_currentMatch = br.ReadInt32();
            m_bestMatch = br.ReadInt32();
            m_timeSinceBetterMatch = br.ReadSingle();
            m_error = br.ReadSingle();
            m_resetCurrentMatchLocalTime = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_currentMatch);
            bw.WriteInt32(m_bestMatch);
            bw.WriteSingle(m_timeSinceBetterMatch);
            bw.WriteSingle(m_error);
            bw.WriteBoolean(m_resetCurrentMatchLocalTime);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_currentMatch), m_currentMatch);
            xs.WriteNumber(xe, nameof(m_bestMatch), m_bestMatch);
            xs.WriteFloat(xe, nameof(m_timeSinceBetterMatch), m_timeSinceBetterMatch);
            xs.WriteFloat(xe, nameof(m_error), m_error);
            xs.WriteBoolean(xe, nameof(m_resetCurrentMatchLocalTime), m_resetCurrentMatchLocalTime);
        }
    }
}

