using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkSweptTransform Signatire: 0xb4e5770 size: 80 flags: FLAGS_NONE

    // m_centerOfMass0 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_centerOfMass1 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_rotation0 m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_rotation1 m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_centerOfMassLocal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkSweptTransform : IHavokObject
    {
        public Vector4 m_centerOfMass0 { set; get; } = default;
        public Vector4 m_centerOfMass1 { set; get; } = default;
        public Quaternion m_rotation0 { set; get; } = default;
        public Quaternion m_rotation1 { set; get; } = default;
        public Vector4 m_centerOfMassLocal { set; get; } = default;

        public virtual uint Signature => 0xb4e5770;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_centerOfMass0 = br.ReadVector4();
            m_centerOfMass1 = br.ReadVector4();
            m_rotation0 = des.ReadQuaternion(br);
            m_rotation1 = des.ReadQuaternion(br);
            m_centerOfMassLocal = br.ReadVector4();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_centerOfMass0);
            bw.WriteVector4(m_centerOfMass1);
            s.WriteQuaternion(bw, m_rotation0);
            s.WriteQuaternion(bw, m_rotation1);
            bw.WriteVector4(m_centerOfMassLocal);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_centerOfMass0 = xd.ReadVector4(xe, nameof(m_centerOfMass0));
            m_centerOfMass1 = xd.ReadVector4(xe, nameof(m_centerOfMass1));
            m_rotation0 = xd.ReadQuaternion(xe, nameof(m_rotation0));
            m_rotation1 = xd.ReadQuaternion(xe, nameof(m_rotation1));
            m_centerOfMassLocal = xd.ReadVector4(xe, nameof(m_centerOfMassLocal));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_centerOfMass0), m_centerOfMass0);
            xs.WriteVector4(xe, nameof(m_centerOfMass1), m_centerOfMass1);
            xs.WriteQuaternion(xe, nameof(m_rotation0), m_rotation0);
            xs.WriteQuaternion(xe, nameof(m_rotation1), m_rotation1);
            xs.WriteVector4(xe, nameof(m_centerOfMassLocal), m_centerOfMassLocal);
        }
    }
}

