using System.Xml.Linq;

namespace HKX2
{
    // BSIStateManagerModifierBSIStateManagerStateListener Signatire: 0x99463586 size: 24 flags: FLAGS_NONE

    // m_pStateManager m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSIStateManagerModifierBSIStateManagerStateListener : hkbStateListener
    {
        public dynamic m_pStateManager;

        public override uint Signature => 0x99463586;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_pStateManager));
        }
    }
}

