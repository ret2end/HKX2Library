using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbProjectData Signatire: 0x13a39ba7 size: 48 flags: FLAGS_NONE

    // m_worldUpWS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_stringData m_class: hkbProjectStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_defaultEventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 40 flags: FLAGS_NONE enum: EventMode
    public partial class hkbProjectData : hkReferencedObject
    {
        public Vector4 m_worldUpWS;
        public hkbProjectStringData m_stringData;
        public sbyte m_defaultEventMode;

        public override uint Signature => 0x13a39ba7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_worldUpWS = br.ReadVector4();
            m_stringData = des.ReadClassPointer<hkbProjectStringData>(br);
            m_defaultEventMode = br.ReadSByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_worldUpWS);
            s.WriteClassPointer(bw, m_stringData);
            s.WriteSByte(bw, m_defaultEventMode);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_worldUpWS = xd.ReadVector4(xe, nameof(m_worldUpWS));
            m_stringData = xd.ReadClassPointer<hkbProjectStringData>(xe, nameof(m_stringData));
            m_defaultEventMode = xd.ReadFlag<EventMode, sbyte>(xe, nameof(m_defaultEventMode));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_worldUpWS), m_worldUpWS);
            xs.WriteClassPointer(xe, nameof(m_stringData), m_stringData);
            xs.WriteEnum<EventMode, sbyte>(xe, nameof(m_defaultEventMode), m_defaultEventMode);
        }
    }
}

