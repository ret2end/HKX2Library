using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSDistTriggerModifier Signatire: 0xb34d2bbd size: 128 flags: FLAGS_NONE

    // m_targetPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_distance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_distanceTrigger m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_triggerEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    public partial class BSDistTriggerModifier : hkbModifier
    {
        public Vector4 m_targetPosition;
        public float m_distance;
        public float m_distanceTrigger;
        public hkbEventProperty m_triggerEvent = new hkbEventProperty();

        public override uint Signature => 0xb34d2bbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_targetPosition = br.ReadVector4();
            m_distance = br.ReadSingle();
            m_distanceTrigger = br.ReadSingle();
            m_triggerEvent = new hkbEventProperty();
            m_triggerEvent.Read(des, br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_targetPosition);
            bw.WriteSingle(m_distance);
            bw.WriteSingle(m_distanceTrigger);
            m_triggerEvent.Write(s, bw);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_targetPosition = xd.ReadVector4(xe, nameof(m_targetPosition));
            m_distance = xd.ReadSingle(xe, nameof(m_distance));
            m_distanceTrigger = xd.ReadSingle(xe, nameof(m_distanceTrigger));
            m_triggerEvent = xd.ReadClass<hkbEventProperty>(xe, nameof(m_triggerEvent));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_targetPosition), m_targetPosition);
            xs.WriteFloat(xe, nameof(m_distance), m_distance);
            xs.WriteFloat(xe, nameof(m_distanceTrigger), m_distanceTrigger);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_triggerEvent), m_triggerEvent);
        }
    }
}

