using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpGravityGun Signatire: 0x5e2754cd size: 128 flags: FLAGS_NONE

    // m_grabbedBodies m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_maxNumObjectsPicked m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_maxMassOfObjectPicked m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags: FLAGS_NONE enum: 
    // m_maxDistOfObjectPicked m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_impulseAppliedWhenObjectNotPicked m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_throwVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_capturedObjectPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_capturedObjectsOffset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    public partial class hkpGravityGun : hkpFirstPersonGun
    {
        public List<dynamic> m_grabbedBodies;
        public int m_maxNumObjectsPicked;
        public float m_maxMassOfObjectPicked;
        public float m_maxDistOfObjectPicked;
        public float m_impulseAppliedWhenObjectNotPicked;
        public float m_throwVelocity;
        public Vector4 m_capturedObjectPosition;
        public Vector4 m_capturedObjectsOffset;

        public override uint Signature => 0x5e2754cd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyArray(br);
            m_maxNumObjectsPicked = br.ReadInt32();
            m_maxMassOfObjectPicked = br.ReadSingle();
            m_maxDistOfObjectPicked = br.ReadSingle();
            m_impulseAppliedWhenObjectNotPicked = br.ReadSingle();
            m_throwVelocity = br.ReadSingle();
            br.Position += 4;
            m_capturedObjectPosition = br.ReadVector4();
            m_capturedObjectsOffset = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidArray(bw);
            bw.WriteInt32(m_maxNumObjectsPicked);
            bw.WriteSingle(m_maxMassOfObjectPicked);
            bw.WriteSingle(m_maxDistOfObjectPicked);
            bw.WriteSingle(m_impulseAppliedWhenObjectNotPicked);
            bw.WriteSingle(m_throwVelocity);
            bw.Position += 4;
            bw.WriteVector4(m_capturedObjectPosition);
            bw.WriteVector4(m_capturedObjectsOffset);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_grabbedBodies));
            xs.WriteNumber(xe, nameof(m_maxNumObjectsPicked), m_maxNumObjectsPicked);
            xs.WriteFloat(xe, nameof(m_maxMassOfObjectPicked), m_maxMassOfObjectPicked);
            xs.WriteFloat(xe, nameof(m_maxDistOfObjectPicked), m_maxDistOfObjectPicked);
            xs.WriteFloat(xe, nameof(m_impulseAppliedWhenObjectNotPicked), m_impulseAppliedWhenObjectNotPicked);
            xs.WriteFloat(xe, nameof(m_throwVelocity), m_throwVelocity);
            xs.WriteVector4(xe, nameof(m_capturedObjectPosition), m_capturedObjectPosition);
            xs.WriteVector4(xe, nameof(m_capturedObjectsOffset), m_capturedObjectsOffset);
        }
    }
}

