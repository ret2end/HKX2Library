using System.Xml.Linq;

namespace HKX2
{
    // hkbRigidBodyRagdollControlsModifier Signatire: 0xaa87d1eb size: 160 flags: FLAGS_NONE

    // m_controlData m_class: hkbRigidBodyRagdollControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_bones m_class: hkbBoneIndexArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    public partial class hkbRigidBodyRagdollControlsModifier : hkbModifier
    {
        public hkbRigidBodyRagdollControlData m_controlData;
        public hkbBoneIndexArray m_bones;

        public override uint Signature => 0xaa87d1eb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_controlData = new hkbRigidBodyRagdollControlData();
            m_controlData.Read(des, br);
            m_bones = des.ReadClassPointer<hkbBoneIndexArray>(br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_controlData.Write(s, bw);
            s.WriteClassPointer(bw, m_bones);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbRigidBodyRagdollControlData>(xe, nameof(m_controlData), m_controlData);
            xs.WriteClassPointer(xe, nameof(m_bones), m_bones);
        }
    }
}

