using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTriggerVolume Signatire: 0xa29a8d1a size: 88 flags: FLAGS_NONE

    // m_overlappingBodies m_class: hkpRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 40 flags:  enum: 
    // m_eventQueue m_class: hkpTriggerVolumeEventInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 56 flags:  enum: 
    // m_triggerBody m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 72 flags:  enum: 
    // m_sequenceNumber m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkpTriggerVolume : hkReferencedObject
    {

        public List<hkpRigidBody> m_overlappingBodies;
        public List<hkpTriggerVolumeEventInfo> m_eventQueue;
        public hkpRigidBody /*pointer struct*/ m_triggerBody;
        public uint m_sequenceNumber;

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

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 24;
            s.WriteClassPointerArray<hkpRigidBody>(bw, m_overlappingBodies);
            s.WriteClassArray<hkpTriggerVolumeEventInfo>(bw, m_eventQueue);
            s.WriteClassPointer(bw, m_triggerBody);
            bw.WriteUInt32(m_sequenceNumber);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

