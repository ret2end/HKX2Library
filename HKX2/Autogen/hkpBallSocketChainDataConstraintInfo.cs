using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpBallSocketChainDataConstraintInfo Signatire: 0xc9cbedf2 size: 32 flags: FLAGS_NONE

    // m_pivotInA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_pivotInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkpBallSocketChainDataConstraintInfo : IHavokObject
    {
        public Vector4 m_pivotInA;
        public Vector4 m_pivotInB;

        public virtual uint Signature => 0xc9cbedf2;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pivotInA = br.ReadVector4();
            m_pivotInB = br.ReadVector4();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_pivotInA);
            bw.WriteVector4(m_pivotInB);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_pivotInA), m_pivotInA);
            xs.WriteVector4(xe, nameof(m_pivotInB), m_pivotInB);
        }
    }
}

