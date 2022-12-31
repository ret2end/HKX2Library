using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineNestedStateMachineData Signatire: 0x7358f5da size: 16 flags: FLAGS_NONE

    // m_nestedStateMachine m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_eventIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 8 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbStateMachineNestedStateMachineData : IHavokObject
    {
        public dynamic m_nestedStateMachine;
        public dynamic m_eventIdMap;

        public virtual uint Signature => 0x7358f5da;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_nestedStateMachine));
            xs.WriteSerializeIgnored(xe, nameof(m_eventIdMap));
        }
    }
}

