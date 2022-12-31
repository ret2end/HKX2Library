using System.Xml.Linq;

namespace HKX2
{
    // hkbRigidBodyRagdollControlData Signatire: 0x1e0bc068 size: 64 flags: FLAGS_NONE

    // m_keyFrameHierarchyControlData m_class: hkaKeyFrameHierarchyUtilityControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_durationToBlend m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkbRigidBodyRagdollControlData : IHavokObject
    {
        public hkaKeyFrameHierarchyUtilityControlData m_keyFrameHierarchyControlData;
        public float m_durationToBlend;

        public virtual uint Signature => 0x1e0bc068;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_keyFrameHierarchyControlData = new hkaKeyFrameHierarchyUtilityControlData();
            m_keyFrameHierarchyControlData.Read(des, br);
            m_durationToBlend = br.ReadSingle();
            br.Position += 12;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_keyFrameHierarchyControlData.Write(s, bw);
            bw.WriteSingle(m_durationToBlend);
            bw.Position += 12;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkaKeyFrameHierarchyUtilityControlData>(xe, nameof(m_keyFrameHierarchyControlData), m_keyFrameHierarchyControlData);
            xs.WriteFloat(xe, nameof(m_durationToBlend), m_durationToBlend);
        }
    }
}

