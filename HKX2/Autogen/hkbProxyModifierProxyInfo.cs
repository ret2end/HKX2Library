using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbProxyModifierProxyInfo Signatire: 0x39de637e size: 80 flags: FLAGS_NONE

    // m_dynamicFriction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_staticFriction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_keepContactTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_up m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_keepDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_contactAngleSensitivity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_userPlanes m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_maxCharacterSpeedForSolver m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    // m_characterStrength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_characterMass m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags: FLAGS_NONE enum: 
    // m_maxSlope m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_penetrationRecoverySpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_maxCastIterations m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_refreshManifoldInCheckSupport m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    public partial class hkbProxyModifierProxyInfo : IHavokObject
    {
        public float m_dynamicFriction;
        public float m_staticFriction;
        public float m_keepContactTolerance;
        public Vector4 m_up;
        public float m_keepDistance;
        public float m_contactAngleSensitivity;
        public uint m_userPlanes;
        public float m_maxCharacterSpeedForSolver;
        public float m_characterStrength;
        public float m_characterMass;
        public float m_maxSlope;
        public float m_penetrationRecoverySpeed;
        public int m_maxCastIterations;
        public bool m_refreshManifoldInCheckSupport;

        public virtual uint Signature => 0x39de637e;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_dynamicFriction = br.ReadSingle();
            m_staticFriction = br.ReadSingle();
            m_keepContactTolerance = br.ReadSingle();
            br.Position += 4;
            m_up = br.ReadVector4();
            m_keepDistance = br.ReadSingle();
            m_contactAngleSensitivity = br.ReadSingle();
            m_userPlanes = br.ReadUInt32();
            m_maxCharacterSpeedForSolver = br.ReadSingle();
            m_characterStrength = br.ReadSingle();
            m_characterMass = br.ReadSingle();
            m_maxSlope = br.ReadSingle();
            m_penetrationRecoverySpeed = br.ReadSingle();
            m_maxCastIterations = br.ReadInt32();
            m_refreshManifoldInCheckSupport = br.ReadBoolean();
            br.Position += 11;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_dynamicFriction);
            bw.WriteSingle(m_staticFriction);
            bw.WriteSingle(m_keepContactTolerance);
            bw.Position += 4;
            bw.WriteVector4(m_up);
            bw.WriteSingle(m_keepDistance);
            bw.WriteSingle(m_contactAngleSensitivity);
            bw.WriteUInt32(m_userPlanes);
            bw.WriteSingle(m_maxCharacterSpeedForSolver);
            bw.WriteSingle(m_characterStrength);
            bw.WriteSingle(m_characterMass);
            bw.WriteSingle(m_maxSlope);
            bw.WriteSingle(m_penetrationRecoverySpeed);
            bw.WriteInt32(m_maxCastIterations);
            bw.WriteBoolean(m_refreshManifoldInCheckSupport);
            bw.Position += 11;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_dynamicFriction), m_dynamicFriction);
            xs.WriteFloat(xe, nameof(m_staticFriction), m_staticFriction);
            xs.WriteFloat(xe, nameof(m_keepContactTolerance), m_keepContactTolerance);
            xs.WriteVector4(xe, nameof(m_up), m_up);
            xs.WriteFloat(xe, nameof(m_keepDistance), m_keepDistance);
            xs.WriteFloat(xe, nameof(m_contactAngleSensitivity), m_contactAngleSensitivity);
            xs.WriteNumber(xe, nameof(m_userPlanes), m_userPlanes);
            xs.WriteFloat(xe, nameof(m_maxCharacterSpeedForSolver), m_maxCharacterSpeedForSolver);
            xs.WriteFloat(xe, nameof(m_characterStrength), m_characterStrength);
            xs.WriteFloat(xe, nameof(m_characterMass), m_characterMass);
            xs.WriteFloat(xe, nameof(m_maxSlope), m_maxSlope);
            xs.WriteFloat(xe, nameof(m_penetrationRecoverySpeed), m_penetrationRecoverySpeed);
            xs.WriteNumber(xe, nameof(m_maxCastIterations), m_maxCastIterations);
            xs.WriteBoolean(xe, nameof(m_refreshManifoldInCheckSupport), m_refreshManifoldInCheckSupport);
        }
    }
}

