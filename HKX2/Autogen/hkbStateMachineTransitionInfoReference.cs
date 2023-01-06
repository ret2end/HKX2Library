using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineTransitionInfoReference Signatire: 0x9810c2d0 size: 6 flags: FLAGS_NONE

    // m_fromStateIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_transitionIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_stateMachineId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineTransitionInfoReference : IHavokObject
    {
        public short m_fromStateIndex;
        public short m_transitionIndex;
        public short m_stateMachineId;

        public virtual uint Signature => 0x9810c2d0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_fromStateIndex = br.ReadInt16();
            m_transitionIndex = br.ReadInt16();
            m_stateMachineId = br.ReadInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt16(m_fromStateIndex);
            bw.WriteInt16(m_transitionIndex);
            bw.WriteInt16(m_stateMachineId);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_fromStateIndex = xd.ReadInt16(xe, nameof(m_fromStateIndex));
            m_transitionIndex = xd.ReadInt16(xe, nameof(m_transitionIndex));
            m_stateMachineId = xd.ReadInt16(xe, nameof(m_stateMachineId));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_fromStateIndex), m_fromStateIndex);
            xs.WriteNumber(xe, nameof(m_transitionIndex), m_transitionIndex);
            xs.WriteNumber(xe, nameof(m_stateMachineId), m_stateMachineId);
        }
    }
}

