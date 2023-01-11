using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEvaluateHandleModifier Signatire: 0x79757102 size: 240 flags: FLAGS_NONE

    // m_handle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_handlePositionOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_handleRotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_isValidOut m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_extrapolationTimeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags: FLAGS_NONE enum: 
    // m_handleChangeSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_handleChangeMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 140 flags: FLAGS_NONE enum: HandleChangeMode
    // m_oldHandle m_class: hkbHandle Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_oldHandlePosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 192 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_oldHandleRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 208 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_timeSinceLastModify m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_smoothlyChangingHandles m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 228 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbEvaluateHandleModifier : hkbModifier
    {
        public hkbHandle? m_handle { set; get; } = default;
        public Vector4 m_handlePositionOut { set; get; } = default;
        public Quaternion m_handleRotationOut { set; get; } = default;
        public bool m_isValidOut { set; get; } = default;
        public float m_extrapolationTimeStep { set; get; } = default;
        public float m_handleChangeSpeed { set; get; } = default;
        public sbyte m_handleChangeMode { set; get; } = default;
        public hkbHandle m_oldHandle { set; get; } = new();
        private Vector4 m_oldHandlePosition { set; get; } = default;
        private Quaternion m_oldHandleRotation { set; get; } = default;
        private float m_timeSinceLastModify { set; get; } = default;
        private bool m_smoothlyChangingHandles { set; get; } = default;

        public override uint Signature => 0x79757102;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_handle = des.ReadClassPointer<hkbHandle>(br);
            br.Position += 8;
            m_handlePositionOut = br.ReadVector4();
            m_handleRotationOut = des.ReadQuaternion(br);
            m_isValidOut = br.ReadBoolean();
            br.Position += 3;
            m_extrapolationTimeStep = br.ReadSingle();
            m_handleChangeSpeed = br.ReadSingle();
            m_handleChangeMode = br.ReadSByte();
            br.Position += 3;
            m_oldHandle.Read(des, br);
            m_oldHandlePosition = br.ReadVector4();
            m_oldHandleRotation = des.ReadQuaternion(br);
            m_timeSinceLastModify = br.ReadSingle();
            m_smoothlyChangingHandles = br.ReadBoolean();
            br.Position += 11;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_handle);
            bw.Position += 8;
            bw.WriteVector4(m_handlePositionOut);
            s.WriteQuaternion(bw, m_handleRotationOut);
            bw.WriteBoolean(m_isValidOut);
            bw.Position += 3;
            bw.WriteSingle(m_extrapolationTimeStep);
            bw.WriteSingle(m_handleChangeSpeed);
            bw.WriteSByte(m_handleChangeMode);
            bw.Position += 3;
            m_oldHandle.Write(s, bw);
            bw.WriteVector4(m_oldHandlePosition);
            s.WriteQuaternion(bw, m_oldHandleRotation);
            bw.WriteSingle(m_timeSinceLastModify);
            bw.WriteBoolean(m_smoothlyChangingHandles);
            bw.Position += 11;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_handle = xd.ReadClassPointer<hkbHandle>(xe, nameof(m_handle));
            m_handlePositionOut = xd.ReadVector4(xe, nameof(m_handlePositionOut));
            m_handleRotationOut = xd.ReadQuaternion(xe, nameof(m_handleRotationOut));
            m_isValidOut = xd.ReadBoolean(xe, nameof(m_isValidOut));
            m_extrapolationTimeStep = xd.ReadSingle(xe, nameof(m_extrapolationTimeStep));
            m_handleChangeSpeed = xd.ReadSingle(xe, nameof(m_handleChangeSpeed));
            m_handleChangeMode = xd.ReadFlag<HandleChangeMode, sbyte>(xe, nameof(m_handleChangeMode));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_handle), m_handle);
            xs.WriteVector4(xe, nameof(m_handlePositionOut), m_handlePositionOut);
            xs.WriteQuaternion(xe, nameof(m_handleRotationOut), m_handleRotationOut);
            xs.WriteBoolean(xe, nameof(m_isValidOut), m_isValidOut);
            xs.WriteFloat(xe, nameof(m_extrapolationTimeStep), m_extrapolationTimeStep);
            xs.WriteFloat(xe, nameof(m_handleChangeSpeed), m_handleChangeSpeed);
            xs.WriteEnum<HandleChangeMode, sbyte>(xe, nameof(m_handleChangeMode), m_handleChangeMode);
            xs.WriteSerializeIgnored(xe, nameof(m_oldHandle));
            xs.WriteSerializeIgnored(xe, nameof(m_oldHandlePosition));
            xs.WriteSerializeIgnored(xe, nameof(m_oldHandleRotation));
            xs.WriteSerializeIgnored(xe, nameof(m_timeSinceLastModify));
            xs.WriteSerializeIgnored(xe, nameof(m_smoothlyChangingHandles));
        }
    }
}

