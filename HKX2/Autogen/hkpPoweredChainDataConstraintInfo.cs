using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpPoweredChainDataConstraintInfo Signatire: 0xf88aee25 size: 96 flags: FLAGS_NONE

    // m_pivotInA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_pivotInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_aTc m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_bTc m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_motors m_class: hkpConstraintMotor Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 3 offset: 64 flags: FLAGS_NONE enum: 
    // m_switchBodies m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    public partial class hkpPoweredChainDataConstraintInfo : IHavokObject
    {
        public Vector4 m_pivotInA;
        public Vector4 m_pivotInB;
        public Quaternion m_aTc;
        public Quaternion m_bTc;
        public hkpConstraintMotor[] m_motors = new hkpConstraintMotor[3];
        public bool m_switchBodies;

        public virtual uint Signature => 0xf88aee25;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pivotInA = br.ReadVector4();
            m_pivotInB = br.ReadVector4();
            m_aTc = des.ReadQuaternion(br);
            m_bTc = des.ReadQuaternion(br);
            m_motors = des.ReadClassPointerCStyleArray<hkpConstraintMotor>(br, 3);
            m_switchBodies = br.ReadBoolean();
            br.Position += 7;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_pivotInA);
            bw.WriteVector4(m_pivotInB);
            s.WriteQuaternion(bw, m_aTc);
            s.WriteQuaternion(bw, m_bTc);
            s.WriteClassPointerCStyleArray(bw, m_motors);
            bw.WriteBoolean(m_switchBodies);
            bw.Position += 7;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_pivotInA = xd.ReadVector4(xe, nameof(m_pivotInA));
            m_pivotInB = xd.ReadVector4(xe, nameof(m_pivotInB));
            m_aTc = xd.ReadQuaternion(xe, nameof(m_aTc));
            m_bTc = xd.ReadQuaternion(xe, nameof(m_bTc));
            m_motors = xd.ReadClassPointerCStyleArray<hkpConstraintMotor>(xe, nameof(m_motors), 3);
            m_switchBodies = xd.ReadBoolean(xe, nameof(m_switchBodies));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_pivotInA), m_pivotInA);
            xs.WriteVector4(xe, nameof(m_pivotInB), m_pivotInB);
            xs.WriteQuaternion(xe, nameof(m_aTc), m_aTc);
            xs.WriteQuaternion(xe, nameof(m_bTc), m_bTc);
            xs.WriteClassPointerArray<hkpConstraintMotor>(xe, nameof(m_motors), m_motors);
            xs.WriteBoolean(xe, nameof(m_switchBodies), m_switchBodies);
        }
    }
}

