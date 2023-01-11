using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpDisplayBindingDataPhysicsSystem Signatire: 0xc8ae86a7 size: 40 flags: FLAGS_NONE

    // m_bindings m_class: hkpDisplayBindingDataRigidBody Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_system m_class: hkpPhysicsSystem Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkpDisplayBindingDataPhysicsSystem : hkReferencedObject
    {
        public IList<hkpDisplayBindingDataRigidBody> m_bindings { set; get; } = new List<hkpDisplayBindingDataRigidBody>();
        public hkpPhysicsSystem? m_system { set; get; } = default;

        public override uint Signature => 0xc8ae86a7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bindings = des.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(br);
            m_system = des.ReadClassPointer<hkpPhysicsSystem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_bindings);
            s.WriteClassPointer(bw, m_system);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_bindings = xd.ReadClassPointerArray<hkpDisplayBindingDataRigidBody>(xe, nameof(m_bindings));
            m_system = xd.ReadClassPointer<hkpPhysicsSystem>(xe, nameof(m_system));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpDisplayBindingDataRigidBody>(xe, nameof(m_bindings), m_bindings);
            xs.WriteClassPointer(xe, nameof(m_system), m_system);
        }
    }
}

