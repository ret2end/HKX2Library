using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineActiveTransitionInfo Signatire: 0xbb90d54f size: 40 flags: FLAGS_NONE

    // m_transitionEffect m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_transitionEffectInternalStateInfo m_class: hkbNodeInternalStateInfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_transitionInfoReference m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_transitionInfoReferenceForTE m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 22 flags: FLAGS_NONE enum: 
    // m_fromStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_toStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_isReturnToPreviousState m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineActiveTransitionInfo : IHavokObject
    {
        public dynamic m_transitionEffect;
        public hkbNodeInternalStateInfo m_transitionEffectInternalStateInfo;
        public hkbStateMachineTransitionInfoReference m_transitionInfoReference = new hkbStateMachineTransitionInfoReference();
        public hkbStateMachineTransitionInfoReference m_transitionInfoReferenceForTE = new hkbStateMachineTransitionInfoReference();
        public int m_fromStateId;
        public int m_toStateId;
        public bool m_isReturnToPreviousState;

        public virtual uint Signature => 0xbb90d54f;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            m_transitionEffectInternalStateInfo = des.ReadClassPointer<hkbNodeInternalStateInfo>(br);
            m_transitionInfoReference = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReference.Read(des, br);
            m_transitionInfoReferenceForTE = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReferenceForTE.Read(des, br);
            m_fromStateId = br.ReadInt32();
            m_toStateId = br.ReadInt32();
            m_isReturnToPreviousState = br.ReadBoolean();
            br.Position += 3;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            s.WriteClassPointer(bw, m_transitionEffectInternalStateInfo);
            m_transitionInfoReference.Write(s, bw);
            m_transitionInfoReferenceForTE.Write(s, bw);
            bw.WriteInt32(m_fromStateId);
            bw.WriteInt32(m_toStateId);
            bw.WriteBoolean(m_isReturnToPreviousState);
            bw.Position += 3;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_transitionEffect = default;
            m_transitionEffectInternalStateInfo = xd.ReadClassPointer<hkbNodeInternalStateInfo>(xe, nameof(m_transitionEffectInternalStateInfo));
            m_transitionInfoReference = xd.ReadClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReference));
            m_transitionInfoReferenceForTE = xd.ReadClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReferenceForTE));
            m_fromStateId = xd.ReadInt32(xe, nameof(m_fromStateId));
            m_toStateId = xd.ReadInt32(xe, nameof(m_toStateId));
            m_isReturnToPreviousState = xd.ReadBoolean(xe, nameof(m_isReturnToPreviousState));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_transitionEffect));
            xs.WriteClassPointer(xe, nameof(m_transitionEffectInternalStateInfo), m_transitionEffectInternalStateInfo);
            xs.WriteClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReference), m_transitionInfoReference);
            xs.WriteClass<hkbStateMachineTransitionInfoReference>(xe, nameof(m_transitionInfoReferenceForTE), m_transitionInfoReferenceForTE);
            xs.WriteNumber(xe, nameof(m_fromStateId), m_fromStateId);
            xs.WriteNumber(xe, nameof(m_toStateId), m_toStateId);
            xs.WriteBoolean(xe, nameof(m_isReturnToPreviousState), m_isReturnToPreviousState);
        }
    }
}

