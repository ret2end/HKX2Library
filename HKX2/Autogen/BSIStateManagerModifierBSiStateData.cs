using System.Xml.Linq;

namespace HKX2
{
    // BSIStateManagerModifierBSiStateData Signatire: 0x6b8a15fc size: 16 flags: FLAGS_NONE

    // m_pStateMachine m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_StateID m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_iStateToSetAs m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class BSIStateManagerModifierBSiStateData : IHavokObject
    {
        public hkbGenerator m_pStateMachine;
        public int m_StateID;
        public int m_iStateToSetAs;

        public virtual uint Signature => 0x6b8a15fc;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pStateMachine = des.ReadClassPointer<hkbGenerator>(br);
            m_StateID = br.ReadInt32();
            m_iStateToSetAs = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_pStateMachine);
            bw.WriteInt32(m_StateID);
            bw.WriteInt32(m_iStateToSetAs);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_pStateMachine), m_pStateMachine);
            xs.WriteNumber(xe, nameof(m_StateID), m_StateID);
            xs.WriteNumber(xe, nameof(m_iStateToSetAs), m_iStateToSetAs);
        }
    }
}

