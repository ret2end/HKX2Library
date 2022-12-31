using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpDisplayBindingData Signatire: 0xdc46c906 size: 48 flags: FLAGS_NONE

    // m_rigidBodyBindings m_class: hkpDisplayBindingDataRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_physicsSystemBindings m_class: hkpDisplayBindingDataPhysicsSystem Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkpDisplayBindingData : hkReferencedObject
    {
        public List<hkpDisplayBindingDataRigidBody> m_rigidBodyBindings;
        public List<hkpDisplayBindingDataPhysicsSystem> m_physicsSystemBindings;

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
            s.WriteClassPointerArray<hkpDisplayBindingDataRigidBody>(bw, m_rigidBodyBindings);
            s.WriteClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(bw, m_physicsSystemBindings);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpDisplayBindingDataRigidBody>(xe, nameof(m_rigidBodyBindings), m_rigidBodyBindings);
            xs.WriteClassPointerArray<hkpDisplayBindingDataPhysicsSystem>(xe, nameof(m_physicsSystemBindings), m_physicsSystemBindings);
        }
    }
}

