using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpTriggerVolume Signatire: 0xa29a8d1a size: 88 flags: FLAGS_NONE

    // m_overlappingBodies m_class: hkpRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_eventQueue m_class: hkpTriggerVolumeEventInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_triggerBody m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_sequenceNumber m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkpTriggerVolume : hkReferencedObject
    {
        public IList<hkpRigidBody> m_overlappingBodies { set; get; } = new List<hkpRigidBody>();
        public IList<hkpTriggerVolumeEventInfo> m_eventQueue { set; get; } = new List<hkpTriggerVolumeEventInfo>();
        public hkpRigidBody? m_triggerBody { set; get; } = default;
        public uint m_sequenceNumber { set; get; } = default;

        public override uint Signature => 0xa29a8d1a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 24;
            m_overlappingBodies = des.ReadClassPointerArray<hkpRigidBody>(br);
            m_eventQueue = des.ReadClassArray<hkpTriggerVolumeEventInfo>(br);
            m_triggerBody = des.ReadClassPointer<hkpRigidBody>(br);
            m_sequenceNumber = br.ReadUInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 24;
            s.WriteClassPointerArray(bw, m_overlappingBodies);
            s.WriteClassArray(bw, m_eventQueue);
            s.WriteClassPointer(bw, m_triggerBody);
            bw.WriteUInt32(m_sequenceNumber);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_overlappingBodies = xd.ReadClassPointerArray<hkpRigidBody>(xe, nameof(m_overlappingBodies));
            m_eventQueue = xd.ReadClassArray<hkpTriggerVolumeEventInfo>(xe, nameof(m_eventQueue));
            m_triggerBody = xd.ReadClassPointer<hkpRigidBody>(xe, nameof(m_triggerBody));
            m_sequenceNumber = xd.ReadUInt32(xe, nameof(m_sequenceNumber));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpRigidBody>(xe, nameof(m_overlappingBodies), m_overlappingBodies);
            xs.WriteClassArray<hkpTriggerVolumeEventInfo>(xe, nameof(m_eventQueue), m_eventQueue);
            xs.WriteClassPointer(xe, nameof(m_triggerBody), m_triggerBody);
            xs.WriteNumber(xe, nameof(m_sequenceNumber), m_sequenceNumber);
        }
    }
}

