using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineProspectiveTransitionInfo Signatire: 0x3ab09a2e size: 16 flags: FLAGS_NONE

    // m_transitionInfoReference m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_transitionInfoReferenceForTE m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 6 flags: FLAGS_NONE enum: 
    // m_toStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineProspectiveTransitionInfo : IHavokObject
    {
        public hkbStateMachineTransitionInfoReference m_transitionInfoReference = new hkbStateMachineTransitionInfoReference();
        public hkbStateMachineTransitionInfoReference m_transitionInfoReferenceForTE = new hkbStateMachineTransitionInfoReference();
        public int m_toStateId;

        public virtual uint Signature => 0x3ab09a2e;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transitionInfoReference = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReference.Read(des, br);
            m_transitionInfoReferenceForTE = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReferenceForTE.Read(des, br);
            m_toStateId = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transitionInfoReference.Write(s, bw);
            m_transitionInfoReferenceForTE.Write(s, bw);
            bw.WriteInt32(m_toStateId);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_transitionInfoReference = xd.ReadClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReference));
            m_transitionInfoReferenceForTE = xd.ReadClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReferenceForTE));
            m_toStateId = xd.ReadInt32(xe, nameof(m_toStateId));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReference), m_transitionInfoReference);
            xs.WriteClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReferenceForTE), m_transitionInfoReferenceForTE);
            xs.WriteNumber(xe, nameof(m_toStateId), m_toStateId);
        }
    }
}

