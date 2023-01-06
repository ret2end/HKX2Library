using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbProxyModifier Signatire: 0x8a41554f size: 288 flags: FLAGS_NONE

    // m_proxyInfo m_class: hkbProxyModifierProxyInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_linearVelocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_horizontalGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_verticalGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 180 flags: FLAGS_NONE enum: 
    // m_maxHorizontalSeparation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    // m_maxVerticalSeparation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags: FLAGS_NONE enum: 
    // m_verticalDisplacementError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 192 flags: FLAGS_NONE enum: 
    // m_verticalDisplacementErrorGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_maxVerticalDisplacement m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 200 flags: FLAGS_NONE enum: 
    // m_minVerticalDisplacement m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 204 flags: FLAGS_NONE enum: 
    // m_capsuleHeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 208 flags: FLAGS_NONE enum: 
    // m_capsuleRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 212 flags: FLAGS_NONE enum: 
    // m_maxSlopeForRotation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 216 flags: FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 220 flags: FLAGS_NONE enum: 
    // m_phantomType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 224 flags: FLAGS_NONE enum: PhantomType
    // m_linearVelocityMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 225 flags: FLAGS_NONE enum: LinearVelocityMode
    // m_ignoreIncomingRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 226 flags: FLAGS_NONE enum: 
    // m_ignoreCollisionDuringRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 227 flags: FLAGS_NONE enum: 
    // m_ignoreIncomingTranslation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 228 flags: FLAGS_NONE enum: 
    // m_includeDownwardMomentum m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 229 flags: FLAGS_NONE enum: 
    // m_followWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 230 flags: FLAGS_NONE enum: 
    // m_isTouchingGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 231 flags: FLAGS_NONE enum: 
    // m_characterProxy m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_phantom m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 240 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_phantomShape m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 248 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_horizontalDisplacement m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 256 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_verticalDisplacement m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 272 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_timestep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 276 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_previousFrameFollowWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 280 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbProxyModifier : hkbModifier
    {
        public hkbProxyModifierProxyInfo m_proxyInfo = new hkbProxyModifierProxyInfo();
        public Vector4 m_linearVelocity;
        public float m_horizontalGain;
        public float m_verticalGain;
        public float m_maxHorizontalSeparation;
        public float m_maxVerticalSeparation;
        public float m_verticalDisplacementError;
        public float m_verticalDisplacementErrorGain;
        public float m_maxVerticalDisplacement;
        public float m_minVerticalDisplacement;
        public float m_capsuleHeight;
        public float m_capsuleRadius;
        public float m_maxSlopeForRotation;
        public uint m_collisionFilterInfo;
        public sbyte m_phantomType;
        public sbyte m_linearVelocityMode;
        public bool m_ignoreIncomingRotation;
        public bool m_ignoreCollisionDuringRotation;
        public bool m_ignoreIncomingTranslation;
        public bool m_includeDownwardMomentum;
        public bool m_followWorldFromModel;
        public bool m_isTouchingGround;
        public dynamic m_characterProxy;
        public dynamic m_phantom;
        public dynamic m_phantomShape;
        public Vector4 m_horizontalDisplacement;
        public float m_verticalDisplacement;
        public float m_timestep;
        public bool m_previousFrameFollowWorldFromModel;

        public override uint Signature => 0x8a41554f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_proxyInfo = new hkbProxyModifierProxyInfo();
            m_proxyInfo.Read(des, br);
            m_linearVelocity = br.ReadVector4();
            m_horizontalGain = br.ReadSingle();
            m_verticalGain = br.ReadSingle();
            m_maxHorizontalSeparation = br.ReadSingle();
            m_maxVerticalSeparation = br.ReadSingle();
            m_verticalDisplacementError = br.ReadSingle();
            m_verticalDisplacementErrorGain = br.ReadSingle();
            m_maxVerticalDisplacement = br.ReadSingle();
            m_minVerticalDisplacement = br.ReadSingle();
            m_capsuleHeight = br.ReadSingle();
            m_capsuleRadius = br.ReadSingle();
            m_maxSlopeForRotation = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            m_phantomType = br.ReadSByte();
            m_linearVelocityMode = br.ReadSByte();
            m_ignoreIncomingRotation = br.ReadBoolean();
            m_ignoreCollisionDuringRotation = br.ReadBoolean();
            m_ignoreIncomingTranslation = br.ReadBoolean();
            m_includeDownwardMomentum = br.ReadBoolean();
            m_followWorldFromModel = br.ReadBoolean();
            m_isTouchingGround = br.ReadBoolean();
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            m_horizontalDisplacement = br.ReadVector4();
            m_verticalDisplacement = br.ReadSingle();
            m_timestep = br.ReadSingle();
            m_previousFrameFollowWorldFromModel = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_proxyInfo.Write(s, bw);
            bw.WriteVector4(m_linearVelocity);
            bw.WriteSingle(m_horizontalGain);
            bw.WriteSingle(m_verticalGain);
            bw.WriteSingle(m_maxHorizontalSeparation);
            bw.WriteSingle(m_maxVerticalSeparation);
            bw.WriteSingle(m_verticalDisplacementError);
            bw.WriteSingle(m_verticalDisplacementErrorGain);
            bw.WriteSingle(m_maxVerticalDisplacement);
            bw.WriteSingle(m_minVerticalDisplacement);
            bw.WriteSingle(m_capsuleHeight);
            bw.WriteSingle(m_capsuleRadius);
            bw.WriteSingle(m_maxSlopeForRotation);
            bw.WriteUInt32(m_collisionFilterInfo);
            s.WriteSByte(bw, m_phantomType);
            s.WriteSByte(bw, m_linearVelocityMode);
            bw.WriteBoolean(m_ignoreIncomingRotation);
            bw.WriteBoolean(m_ignoreCollisionDuringRotation);
            bw.WriteBoolean(m_ignoreIncomingTranslation);
            bw.WriteBoolean(m_includeDownwardMomentum);
            bw.WriteBoolean(m_followWorldFromModel);
            bw.WriteBoolean(m_isTouchingGround);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            bw.WriteVector4(m_horizontalDisplacement);
            bw.WriteSingle(m_verticalDisplacement);
            bw.WriteSingle(m_timestep);
            bw.WriteBoolean(m_previousFrameFollowWorldFromModel);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_proxyInfo = xd.ReadClass<hkbProxyModifierProxyInfo>(xe, nameof(m_proxyInfo));
            m_linearVelocity = xd.ReadVector4(xe, nameof(m_linearVelocity));
            m_horizontalGain = xd.ReadSingle(xe, nameof(m_horizontalGain));
            m_verticalGain = xd.ReadSingle(xe, nameof(m_verticalGain));
            m_maxHorizontalSeparation = xd.ReadSingle(xe, nameof(m_maxHorizontalSeparation));
            m_maxVerticalSeparation = xd.ReadSingle(xe, nameof(m_maxVerticalSeparation));
            m_verticalDisplacementError = xd.ReadSingle(xe, nameof(m_verticalDisplacementError));
            m_verticalDisplacementErrorGain = xd.ReadSingle(xe, nameof(m_verticalDisplacementErrorGain));
            m_maxVerticalDisplacement = xd.ReadSingle(xe, nameof(m_maxVerticalDisplacement));
            m_minVerticalDisplacement = xd.ReadSingle(xe, nameof(m_minVerticalDisplacement));
            m_capsuleHeight = xd.ReadSingle(xe, nameof(m_capsuleHeight));
            m_capsuleRadius = xd.ReadSingle(xe, nameof(m_capsuleRadius));
            m_maxSlopeForRotation = xd.ReadSingle(xe, nameof(m_maxSlopeForRotation));
            m_collisionFilterInfo = xd.ReadUInt32(xe, nameof(m_collisionFilterInfo));
            m_phantomType = xd.ReadFlag<PhantomType, sbyte>(xe, nameof(m_phantomType));
            m_linearVelocityMode = xd.ReadFlag<LinearVelocityMode, sbyte>(xe, nameof(m_linearVelocityMode));
            m_ignoreIncomingRotation = xd.ReadBoolean(xe, nameof(m_ignoreIncomingRotation));
            m_ignoreCollisionDuringRotation = xd.ReadBoolean(xe, nameof(m_ignoreCollisionDuringRotation));
            m_ignoreIncomingTranslation = xd.ReadBoolean(xe, nameof(m_ignoreIncomingTranslation));
            m_includeDownwardMomentum = xd.ReadBoolean(xe, nameof(m_includeDownwardMomentum));
            m_followWorldFromModel = xd.ReadBoolean(xe, nameof(m_followWorldFromModel));
            m_isTouchingGround = xd.ReadBoolean(xe, nameof(m_isTouchingGround));
            m_characterProxy = default;
            m_phantom = default;
            m_phantomShape = default;
            m_horizontalDisplacement = default;
            m_verticalDisplacement = default;
            m_timestep = default;
            m_previousFrameFollowWorldFromModel = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbProxyModifierProxyInfo>(xe, nameof(m_proxyInfo), m_proxyInfo);
            xs.WriteVector4(xe, nameof(m_linearVelocity), m_linearVelocity);
            xs.WriteFloat(xe, nameof(m_horizontalGain), m_horizontalGain);
            xs.WriteFloat(xe, nameof(m_verticalGain), m_verticalGain);
            xs.WriteFloat(xe, nameof(m_maxHorizontalSeparation), m_maxHorizontalSeparation);
            xs.WriteFloat(xe, nameof(m_maxVerticalSeparation), m_maxVerticalSeparation);
            xs.WriteFloat(xe, nameof(m_verticalDisplacementError), m_verticalDisplacementError);
            xs.WriteFloat(xe, nameof(m_verticalDisplacementErrorGain), m_verticalDisplacementErrorGain);
            xs.WriteFloat(xe, nameof(m_maxVerticalDisplacement), m_maxVerticalDisplacement);
            xs.WriteFloat(xe, nameof(m_minVerticalDisplacement), m_minVerticalDisplacement);
            xs.WriteFloat(xe, nameof(m_capsuleHeight), m_capsuleHeight);
            xs.WriteFloat(xe, nameof(m_capsuleRadius), m_capsuleRadius);
            xs.WriteFloat(xe, nameof(m_maxSlopeForRotation), m_maxSlopeForRotation);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
            xs.WriteEnum<PhantomType, sbyte>(xe, nameof(m_phantomType), m_phantomType);
            xs.WriteEnum<LinearVelocityMode, sbyte>(xe, nameof(m_linearVelocityMode), m_linearVelocityMode);
            xs.WriteBoolean(xe, nameof(m_ignoreIncomingRotation), m_ignoreIncomingRotation);
            xs.WriteBoolean(xe, nameof(m_ignoreCollisionDuringRotation), m_ignoreCollisionDuringRotation);
            xs.WriteBoolean(xe, nameof(m_ignoreIncomingTranslation), m_ignoreIncomingTranslation);
            xs.WriteBoolean(xe, nameof(m_includeDownwardMomentum), m_includeDownwardMomentum);
            xs.WriteBoolean(xe, nameof(m_followWorldFromModel), m_followWorldFromModel);
            xs.WriteBoolean(xe, nameof(m_isTouchingGround), m_isTouchingGround);
            xs.WriteSerializeIgnored(xe, nameof(m_characterProxy));
            xs.WriteSerializeIgnored(xe, nameof(m_phantom));
            xs.WriteSerializeIgnored(xe, nameof(m_phantomShape));
            xs.WriteSerializeIgnored(xe, nameof(m_horizontalDisplacement));
            xs.WriteSerializeIgnored(xe, nameof(m_verticalDisplacement));
            xs.WriteSerializeIgnored(xe, nameof(m_timestep));
            xs.WriteSerializeIgnored(xe, nameof(m_previousFrameFollowWorldFromModel));
        }
    }
}

