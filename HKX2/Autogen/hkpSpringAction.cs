using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSpringAction Signatire: 0x88fc09fa size: 128 flags: FLAGS_NONE

    // m_lastForce m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_positionAinA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_positionBinB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_restLength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags: FLAGS_NONE enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    // m_onCompression m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 124 flags: FLAGS_NONE enum: 
    // m_onExtension m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 125 flags: FLAGS_NONE enum: 
    public partial class hkpSpringAction : hkpBinaryAction
    {
        public Vector4 m_lastForce;
        public Vector4 m_positionAinA;
        public Vector4 m_positionBinB;
        public float m_restLength;
        public float m_strength;
        public float m_damping;
        public bool m_onCompression;
        public bool m_onExtension;

        public override uint Signature => 0x88fc09fa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_lastForce = br.ReadVector4();
            m_positionAinA = br.ReadVector4();
            m_positionBinB = br.ReadVector4();
            m_restLength = br.ReadSingle();
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_onCompression = br.ReadBoolean();
            m_onExtension = br.ReadBoolean();
            br.Position += 2;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_lastForce);
            bw.WriteVector4(m_positionAinA);
            bw.WriteVector4(m_positionBinB);
            bw.WriteSingle(m_restLength);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.WriteBoolean(m_onCompression);
            bw.WriteBoolean(m_onExtension);
            bw.Position += 2;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_lastForce = xd.ReadVector4(xe, nameof(m_lastForce));
            m_positionAinA = xd.ReadVector4(xe, nameof(m_positionAinA));
            m_positionBinB = xd.ReadVector4(xe, nameof(m_positionBinB));
            m_restLength = xd.ReadSingle(xe, nameof(m_restLength));
            m_strength = xd.ReadSingle(xe, nameof(m_strength));
            m_damping = xd.ReadSingle(xe, nameof(m_damping));
            m_onCompression = xd.ReadBoolean(xe, nameof(m_onCompression));
            m_onExtension = xd.ReadBoolean(xe, nameof(m_onExtension));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_lastForce), m_lastForce);
            xs.WriteVector4(xe, nameof(m_positionAinA), m_positionAinA);
            xs.WriteVector4(xe, nameof(m_positionBinB), m_positionBinB);
            xs.WriteFloat(xe, nameof(m_restLength), m_restLength);
            xs.WriteFloat(xe, nameof(m_strength), m_strength);
            xs.WriteFloat(xe, nameof(m_damping), m_damping);
            xs.WriteBoolean(xe, nameof(m_onCompression), m_onCompression);
            xs.WriteBoolean(xe, nameof(m_onExtension), m_onExtension);
        }
    }
}

