using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbTransitionEffect Signatire: 0x945da157 size: 80 flags: FLAGS_NONE

    // m_selfTransitionMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 72 flags: FLAGS_NONE enum: SelfTransitionMode
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 73 flags: FLAGS_NONE enum: EventMode
    // m_defaultEventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 74 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbTransitionEffect : hkbGenerator
    {
        public sbyte m_selfTransitionMode { set; get; } = default;
        public sbyte m_eventMode { set; get; } = default;
        private sbyte m_defaultEventMode { set; get; } = default;

        public override uint Signature => 0x945da157;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_selfTransitionMode = br.ReadSByte();
            m_eventMode = br.ReadSByte();
            m_defaultEventMode = br.ReadSByte();
            br.Position += 5;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSByte(m_selfTransitionMode);
            bw.WriteSByte(m_eventMode);
            bw.WriteSByte(m_defaultEventMode);
            bw.Position += 5;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_selfTransitionMode = xd.ReadFlag<SelfTransitionMode, sbyte>(xe, nameof(m_selfTransitionMode));
            m_eventMode = xd.ReadFlag<EventMode, sbyte>(xe, nameof(m_eventMode));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<SelfTransitionMode, sbyte>(xe, nameof(m_selfTransitionMode), m_selfTransitionMode);
            xs.WriteEnum<EventMode, sbyte>(xe, nameof(m_eventMode), m_eventMode);
            xs.WriteSerializeIgnored(xe, nameof(m_defaultEventMode));
        }
    }
}

