using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbAuxiliaryNodeInfo Signatire: 0xca0888ca size: 48 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: NodeType
    // m_depth m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 17 flags: FLAGS_NONE enum: 
    // m_referenceBehaviorName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_selfTransitionNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbAuxiliaryNodeInfo : hkReferencedObject
    {
        public byte m_type;
        public byte m_depth;
        public string m_referenceBehaviorName;
        public List<string> m_selfTransitionNames;

        public override uint Signature => 0xca0888ca;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = br.ReadByte();
            m_depth = br.ReadByte();
            br.Position += 6;
            m_referenceBehaviorName = des.ReadStringPointer(br);
            m_selfTransitionNames = des.ReadStringPointerArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteByte(bw, m_type);
            bw.WriteByte(m_depth);
            bw.Position += 6;
            s.WriteStringPointer(bw, m_referenceBehaviorName);
            s.WriteStringPointerArray(bw, m_selfTransitionNames);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_type = xd.ReadFlag<NodeType, byte>(xe, nameof(m_type));
            m_depth = xd.ReadByte(xe, nameof(m_depth));
            m_referenceBehaviorName = xd.ReadString(xe, nameof(m_referenceBehaviorName));
            m_selfTransitionNames = xd.ReadStringArray(xe, nameof(m_selfTransitionNames));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<NodeType, byte>(xe, nameof(m_type), m_type);
            xs.WriteNumber(xe, nameof(m_depth), m_depth);
            xs.WriteString(xe, nameof(m_referenceBehaviorName), m_referenceBehaviorName);
            xs.WriteStringArray(xe, nameof(m_selfTransitionNames), m_selfTransitionNames);
        }
    }
}

