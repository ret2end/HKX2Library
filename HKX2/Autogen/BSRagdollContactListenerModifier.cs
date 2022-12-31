using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // BSRagdollContactListenerModifier Signatire: 0x8003d8ce size: 136 flags: FLAGS_NONE

    // m_contactEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_bones m_class: hkbBoneIndexArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_throwEvent m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_ragdollRigidBodies m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSRagdollContactListenerModifier : hkbModifier
    {
        public hkbEventProperty m_contactEvent;
        public hkbBoneIndexArray m_bones;
        public bool m_throwEvent;
        public List<dynamic> m_ragdollRigidBodies;

        public override uint Signature => 0x8003d8ce;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_contactEvent = new hkbEventProperty();
            m_contactEvent.Read(des, br);
            m_bones = des.ReadClassPointer<hkbBoneIndexArray>(br);
            m_throwEvent = br.ReadBoolean();
            br.Position += 7;
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            m_contactEvent.Write(s, bw);
            s.WriteClassPointer(bw, m_bones);
            bw.WriteBoolean(m_throwEvent);
            bw.Position += 7;
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_contactEvent), m_contactEvent);
            xs.WriteClassPointer(xe, nameof(m_bones), m_bones);
            xs.WriteSerializeIgnored(xe, nameof(m_throwEvent));
            xs.WriteSerializeIgnored(xe, nameof(m_ragdollRigidBodies));
        }
    }
}

