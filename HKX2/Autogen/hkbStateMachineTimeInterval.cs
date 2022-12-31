using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineTimeInterval Signatire: 0x60a881e5 size: 16 flags: FLAGS_NONE

    // m_enterEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_exitEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_enterTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_exitTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineTimeInterval : IHavokObject
    {
        public int m_enterEventId;
        public int m_exitEventId;
        public float m_enterTime;
        public float m_exitTime;

        public virtual uint Signature => 0x60a881e5;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_enterEventId = br.ReadInt32();
            m_exitEventId = br.ReadInt32();
            m_enterTime = br.ReadSingle();
            m_exitTime = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_enterEventId);
            bw.WriteInt32(m_exitEventId);
            bw.WriteSingle(m_enterTime);
            bw.WriteSingle(m_exitTime);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_enterEventId), m_enterEventId);
            xs.WriteNumber(xe, nameof(m_exitEventId), m_exitEventId);
            xs.WriteFloat(xe, nameof(m_enterTime), m_enterTime);
            xs.WriteFloat(xe, nameof(m_exitTime), m_exitTime);
        }
    }
}

