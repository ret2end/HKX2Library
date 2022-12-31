using System.Xml.Linq;

namespace HKX2
{
    // BSSpeedSamplerModifier Signatire: 0xd297fda9 size: 96 flags: FLAGS_NONE

    // m_state m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_direction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_goalSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_speedOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    public partial class BSSpeedSamplerModifier : hkbModifier
    {
        public int m_state;
        public float m_direction;
        public float m_goalSpeed;
        public float m_speedOut;

        public override uint Signature => 0xd297fda9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_state = br.ReadInt32();
            m_direction = br.ReadSingle();
            m_goalSpeed = br.ReadSingle();
            m_speedOut = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_state);
            bw.WriteSingle(m_direction);
            bw.WriteSingle(m_goalSpeed);
            bw.WriteSingle(m_speedOut);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_state), m_state);
            xs.WriteFloat(xe, nameof(m_direction), m_direction);
            xs.WriteFloat(xe, nameof(m_goalSpeed), m_goalSpeed);
            xs.WriteFloat(xe, nameof(m_speedOut), m_speedOut);
        }
    }
}

