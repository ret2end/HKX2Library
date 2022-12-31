using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbComputeRotationFromAxisAngleModifier Signatire: 0x9b3f6936 size: 128 flags: FLAGS_NONE

    // m_rotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_axis m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_angleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    public partial class hkbComputeRotationFromAxisAngleModifier : hkbModifier
    {
        public Quaternion m_rotationOut;
        public Vector4 m_axis;
        public float m_angleDegrees;

        public override uint Signature => 0x9b3f6936;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rotationOut = des.ReadQuaternion(br);
            m_axis = br.ReadVector4();
            m_angleDegrees = br.ReadSingle();
            br.Position += 12;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotationOut);
            bw.WriteVector4(m_axis);
            bw.WriteSingle(m_angleDegrees);
            bw.Position += 12;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteQuaternion(xe, nameof(m_rotationOut), m_rotationOut);
            xs.WriteVector4(xe, nameof(m_axis), m_axis);
            xs.WriteFloat(xe, nameof(m_angleDegrees), m_angleDegrees);
        }
    }
}

