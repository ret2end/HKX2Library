using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpDisplayBindingData Signatire: 0xdc46c906 size: 48 flags: FLAGS_NONE

    // m_rigidBodyBindings m_class: hkpDisplayBindingDataRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_physicsSystemBindings m_class: hkpDisplayBindingDataPhysicsSystem Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkpDisplayBindingData : hkReferencedObject
    {
        public IList<hkpDisplayBindingDataRigidBody> m_rigidBodyBindings { set; get; } = new List<hkpDisplayBindingDataRigidBody>();
        public IList<hkpDisplayBindingDataPhysicsSystem> m_physicsSystemBindings { set; get; } = new List<hkpDisplayBindingDataPhysicsSystem>();

        public override uint Signature => 0xdc46c906;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rigidBodyBindings = des.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(br);
            m_physicsSystemBindings = des.ReadClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_rigidBodyBindings);
            s.WriteClassPointerArray(bw, m_physicsSystemBindings);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_rigidBodyBindings = xd.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(xe, nameof(m_rigidBodyBindings));
            m_physicsSystemBindings = xd.ReadClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(xe, nameof(m_physicsSystemBindings));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpDisplayBindingDataRigidBody>(xe, nameof(m_rigidBodyBindings), m_rigidBodyBindings);
            xs.WriteClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(xe, nameof(m_physicsSystemBindings), m_physicsSystemBindings);
        }
    }
}

