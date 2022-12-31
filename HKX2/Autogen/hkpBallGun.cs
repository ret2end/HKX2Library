using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpBallGun Signatire: 0x57b06d35 size: 112 flags: FLAGS_NONE

    // m_bulletRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_bulletVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_bulletMass m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_damageMultiplier m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_maxBulletsInWorld m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_bulletOffsetFromCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_addedBodies m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpBallGun : hkpFirstPersonGun
    {
        public float m_bulletRadius;
        public float m_bulletVelocity;
        public float m_bulletMass;
        public float m_damageMultiplier;
        public int m_maxBulletsInWorld;
        public Vector4 m_bulletOffsetFromCenter;
        public dynamic m_addedBodies;

        public override uint Signature => 0x57b06d35;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bulletRadius = br.ReadSingle();
            m_bulletVelocity = br.ReadSingle();
            m_bulletMass = br.ReadSingle();
            m_damageMultiplier = br.ReadSingle();
            m_maxBulletsInWorld = br.ReadInt32();
            br.Position += 4;
            m_bulletOffsetFromCenter = br.ReadVector4();
            des.ReadEmptyPointer(br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_bulletRadius);
            bw.WriteSingle(m_bulletVelocity);
            bw.WriteSingle(m_bulletMass);
            bw.WriteSingle(m_damageMultiplier);
            bw.WriteInt32(m_maxBulletsInWorld);
            bw.Position += 4;
            bw.WriteVector4(m_bulletOffsetFromCenter);
            s.WriteVoidPointer(bw);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_bulletRadius), m_bulletRadius);
            xs.WriteFloat(xe, nameof(m_bulletVelocity), m_bulletVelocity);
            xs.WriteFloat(xe, nameof(m_bulletMass), m_bulletMass);
            xs.WriteFloat(xe, nameof(m_damageMultiplier), m_damageMultiplier);
            xs.WriteNumber(xe, nameof(m_maxBulletsInWorld), m_maxBulletsInWorld);
            xs.WriteVector4(xe, nameof(m_bulletOffsetFromCenter), m_bulletOffsetFromCenter);
            xs.WriteSerializeIgnored(xe, nameof(m_addedBodies));
        }
    }
}

