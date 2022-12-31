using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMaterial Signatire: 0x33be6570 size: 12 flags: FLAGS_NONE

    // m_responseType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: ResponseType
    // m_rollingFrictionMultiplier m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_friction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_restitution m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpMaterial : IHavokObject
    {
        public sbyte m_responseType;
        public Half m_rollingFrictionMultiplier;
        public float m_friction;
        public float m_restitution;

        public virtual uint Signature => 0x33be6570;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_responseType = br.ReadSByte();
            br.Position += 1;
            m_rollingFrictionMultiplier = br.ReadHalf();
            m_friction = br.ReadSingle();
            m_restitution = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteSByte(bw, m_responseType);
            bw.Position += 1;
            bw.WriteHalf(m_rollingFrictionMultiplier);
            bw.WriteSingle(m_friction);
            bw.WriteSingle(m_restitution);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteEnum<ResponseType, sbyte>(xe, nameof(m_responseType), m_responseType);
            xs.WriteFloat(xe, nameof(m_rollingFrictionMultiplier), m_rollingFrictionMultiplier);
            xs.WriteFloat(xe, nameof(m_friction), m_friction);
            xs.WriteFloat(xe, nameof(m_restitution), m_restitution);
        }
    }
}

