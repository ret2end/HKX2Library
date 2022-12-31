using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // BSIStateManagerModifier Signatire: 0x6cb24f2e size: 128 flags: FLAGS_NONE

    // m_iStateVar m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_stateData m_class: BSIStateManagerModifierBSiStateData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_myStateListener m_class: BSIStateManagerModifierBSIStateManagerStateListener Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSIStateManagerModifier : hkbModifier
    {
        public int m_iStateVar;
        public List<BSIStateManagerModifierBSiStateData> m_stateData;
        public BSIStateManagerModifierBSIStateManagerStateListener m_myStateListener;

        public override uint Signature => 0x6cb24f2e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_iStateVar = br.ReadInt32();
            br.Position += 4;
            m_stateData = des.ReadClassArray<BSIStateManagerModifierBSiStateData>(br);
            m_myStateListener = new BSIStateManagerModifierBSIStateManagerStateListener();
            m_myStateListener.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_iStateVar);
            bw.Position += 4;
            s.WriteClassArray<BSIStateManagerModifierBSiStateData>(bw, m_stateData);
            m_myStateListener.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_iStateVar), m_iStateVar);
            xs.WriteClassArray<BSIStateManagerModifierBSiStateData>(xe, nameof(m_stateData), m_stateData);
            xs.WriteSerializeIgnored(xe, nameof(m_myStateListener));
        }
    }
}

