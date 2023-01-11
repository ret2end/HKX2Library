using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCharacterRigidBodyCinfo Signatire: 0x892f441 size: 128 flags: FLAGS_NONE

    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_mass m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_friction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_maxLinearVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_allowedPenetrationDepth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags: FLAGS_NONE enum: 
    // m_up m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_maxSlope m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_maxForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_unweldingHeightOffsetFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_maxSpeedForSimplexSolver m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    // m_supportDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_hardSupportDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags: FLAGS_NONE enum: 
    // m_vdbColor m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    public partial class hkpCharacterRigidBodyCinfo : hkpCharacterControllerCinfo
    {
        public uint m_collisionFilterInfo { set; get; } = default;
        public hkpShape? m_shape { set; get; } = default;
        public Vector4 m_position { set; get; } = default;
        public Quaternion m_rotation { set; get; } = default;
        public float m_mass { set; get; } = default;
        public float m_friction { set; get; } = default;
        public float m_maxLinearVelocity { set; get; } = default;
        public float m_allowedPenetrationDepth { set; get; } = default;
        public Vector4 m_up { set; get; } = default;
        public float m_maxSlope { set; get; } = default;
        public float m_maxForce { set; get; } = default;
        public float m_unweldingHeightOffsetFactor { set; get; } = default;
        public float m_maxSpeedForSimplexSolver { set; get; } = default;
        public float m_supportDistance { set; get; } = default;
        public float m_hardSupportDistance { set; get; } = default;
        public int m_vdbColor { set; get; } = default;

        public override uint Signature => 0x892f441;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_collisionFilterInfo = br.ReadUInt32();
            br.Position += 4;
            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_position = br.ReadVector4();
            m_rotation = des.ReadQuaternion(br);
            m_mass = br.ReadSingle();
            m_friction = br.ReadSingle();
            m_maxLinearVelocity = br.ReadSingle();
            m_allowedPenetrationDepth = br.ReadSingle();
            m_up = br.ReadVector4();
            m_maxSlope = br.ReadSingle();
            m_maxForce = br.ReadSingle();
            m_unweldingHeightOffsetFactor = br.ReadSingle();
            m_maxSpeedForSimplexSolver = br.ReadSingle();
            m_supportDistance = br.ReadSingle();
            m_hardSupportDistance = br.ReadSingle();
            m_vdbColor = br.ReadInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_shape);
            bw.WriteVector4(m_position);
            s.WriteQuaternion(bw, m_rotation);
            bw.WriteSingle(m_mass);
            bw.WriteSingle(m_friction);
            bw.WriteSingle(m_maxLinearVelocity);
            bw.WriteSingle(m_allowedPenetrationDepth);
            bw.WriteVector4(m_up);
            bw.WriteSingle(m_maxSlope);
            bw.WriteSingle(m_maxForce);
            bw.WriteSingle(m_unweldingHeightOffsetFactor);
            bw.WriteSingle(m_maxSpeedForSimplexSolver);
            bw.WriteSingle(m_supportDistance);
            bw.WriteSingle(m_hardSupportDistance);
            bw.WriteInt32(m_vdbColor);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_collisionFilterInfo = xd.ReadUInt32(xe, nameof(m_collisionFilterInfo));
            m_shape = xd.ReadClassPointer<hkpShape>(xe, nameof(m_shape));
            m_position = xd.ReadVector4(xe, nameof(m_position));
            m_rotation = xd.ReadQuaternion(xe, nameof(m_rotation));
            m_mass = xd.ReadSingle(xe, nameof(m_mass));
            m_friction = xd.ReadSingle(xe, nameof(m_friction));
            m_maxLinearVelocity = xd.ReadSingle(xe, nameof(m_maxLinearVelocity));
            m_allowedPenetrationDepth = xd.ReadSingle(xe, nameof(m_allowedPenetrationDepth));
            m_up = xd.ReadVector4(xe, nameof(m_up));
            m_maxSlope = xd.ReadSingle(xe, nameof(m_maxSlope));
            m_maxForce = xd.ReadSingle(xe, nameof(m_maxForce));
            m_unweldingHeightOffsetFactor = xd.ReadSingle(xe, nameof(m_unweldingHeightOffsetFactor));
            m_maxSpeedForSimplexSolver = xd.ReadSingle(xe, nameof(m_maxSpeedForSimplexSolver));
            m_supportDistance = xd.ReadSingle(xe, nameof(m_supportDistance));
            m_hardSupportDistance = xd.ReadSingle(xe, nameof(m_hardSupportDistance));
            m_vdbColor = xd.ReadInt32(xe, nameof(m_vdbColor));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
            xs.WriteClassPointer(xe, nameof(m_shape), m_shape);
            xs.WriteVector4(xe, nameof(m_position), m_position);
            xs.WriteQuaternion(xe, nameof(m_rotation), m_rotation);
            xs.WriteFloat(xe, nameof(m_mass), m_mass);
            xs.WriteFloat(xe, nameof(m_friction), m_friction);
            xs.WriteFloat(xe, nameof(m_maxLinearVelocity), m_maxLinearVelocity);
            xs.WriteFloat(xe, nameof(m_allowedPenetrationDepth), m_allowedPenetrationDepth);
            xs.WriteVector4(xe, nameof(m_up), m_up);
            xs.WriteFloat(xe, nameof(m_maxSlope), m_maxSlope);
            xs.WriteFloat(xe, nameof(m_maxForce), m_maxForce);
            xs.WriteFloat(xe, nameof(m_unweldingHeightOffsetFactor), m_unweldingHeightOffsetFactor);
            xs.WriteFloat(xe, nameof(m_maxSpeedForSimplexSolver), m_maxSpeedForSimplexSolver);
            xs.WriteFloat(xe, nameof(m_supportDistance), m_supportDistance);
            xs.WriteFloat(xe, nameof(m_hardSupportDistance), m_hardSupportDistance);
            xs.WriteNumber(xe, nameof(m_vdbColor), m_vdbColor);
        }
    }
}

