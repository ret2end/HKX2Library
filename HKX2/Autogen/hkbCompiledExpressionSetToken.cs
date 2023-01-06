using System.Xml.Linq;

namespace HKX2
{
    // hkbCompiledExpressionSetToken Signatire: 0xc6aaccc8 size: 8 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 4 flags: FLAGS_NONE enum: TokenType
    // m_operator m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 5 flags: FLAGS_NONE enum: Operator
    public partial class hkbCompiledExpressionSetToken : IHavokObject
    {
        public float m_data;
        public sbyte m_type;
        public sbyte m_operator;

        public virtual uint Signature => 0xc6aaccc8;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = br.ReadSingle();
            m_type = br.ReadSByte();
            m_operator = br.ReadSByte();
            br.Position += 2;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_data);
            s.WriteSByte(bw, m_type);
            s.WriteSByte(bw, m_operator);
            bw.Position += 2;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_data = xd.ReadSingle(xe, nameof(m_data));
            m_type = xd.ReadFlag<TokenType, sbyte>(xe, nameof(m_type));
            m_operator = xd.ReadFlag<Operator, sbyte>(xe, nameof(m_operator));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_data), m_data);
            xs.WriteEnum<TokenType, sbyte>(xe, nameof(m_type), m_type);
            xs.WriteEnum<Operator, sbyte>(xe, nameof(m_operator), m_operator);
        }
    }
}

