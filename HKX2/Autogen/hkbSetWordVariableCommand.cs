using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbSetWordVariableCommand Signatire: 0xf3ae5fca size: 64 flags: FLAGS_NONE

    // m_quadValue m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_variableId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_value m_class: hkbVariableValue Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: VariableType
    // m_global m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 49 flags: FLAGS_NONE enum: 
    public partial class hkbSetWordVariableCommand : hkReferencedObject
    {
        public Vector4 m_quadValue;
        public ulong m_characterId;
        public int m_variableId;
        public hkbVariableValue m_value;
        public byte m_type;
        public bool m_global;

        public override uint Signature => 0xf3ae5fca;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_quadValue = br.ReadVector4();
            m_characterId = br.ReadUInt64();
            m_variableId = br.ReadInt32();
            m_value = new hkbVariableValue();
            m_value.Read(des, br);
            m_type = br.ReadByte();
            m_global = br.ReadBoolean();
            br.Position += 14;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_quadValue);
            bw.WriteUInt64(m_characterId);
            bw.WriteInt32(m_variableId);
            m_value.Write(s, bw);
            s.WriteByte(bw, m_type);
            bw.WriteBoolean(m_global);
            bw.Position += 14;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_quadValue), m_quadValue);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteNumber(xe, nameof(m_variableId), m_variableId);
            xs.WriteClass<hkbVariableValue>(xe, nameof(m_value), m_value);
            xs.WriteEnum<VariableType, byte>(xe, nameof(m_type), m_type);
            xs.WriteBoolean(xe, nameof(m_global), m_global);
        }
    }
}

