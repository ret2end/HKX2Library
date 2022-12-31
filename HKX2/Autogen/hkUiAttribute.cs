using System.Xml.Linq;

namespace HKX2
{
    // hkUiAttribute Signatire: 0xeb6e96e3 size: 40 flags: FLAGS_NONE

    // m_visible m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_hideInModeler m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 1 flags: FLAGS_NONE enum: HideInModeler
    // m_label m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_group m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_hideBaseClassMembers m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_endGroup m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_endGroup2 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 33 flags: FLAGS_NONE enum: 
    // m_advanced m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 34 flags: FLAGS_NONE enum: 
    public partial class hkUiAttribute : IHavokObject
    {
        public bool m_visible;
        public sbyte m_hideInModeler;
        public string m_label;
        public string m_group;
        public string m_hideBaseClassMembers;
        public bool m_endGroup;
        public bool m_endGroup2;
        public bool m_advanced;

        public virtual uint Signature => 0xeb6e96e3;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_visible = br.ReadBoolean();
            m_hideInModeler = br.ReadSByte();
            br.Position += 6;
            m_label = des.ReadStringPointer(br);
            m_group = des.ReadStringPointer(br);
            m_hideBaseClassMembers = des.ReadStringPointer(br);
            m_endGroup = br.ReadBoolean();
            m_endGroup2 = br.ReadBoolean();
            m_advanced = br.ReadBoolean();
            br.Position += 5;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBoolean(m_visible);
            s.WriteSByte(bw, m_hideInModeler);
            bw.Position += 6;
            s.WriteStringPointer(bw, m_label);
            s.WriteStringPointer(bw, m_group);
            s.WriteStringPointer(bw, m_hideBaseClassMembers);
            bw.WriteBoolean(m_endGroup);
            bw.WriteBoolean(m_endGroup2);
            bw.WriteBoolean(m_advanced);
            bw.Position += 5;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteBoolean(xe, nameof(m_visible), m_visible);
            xs.WriteEnum<HideInModeler, sbyte>(xe, nameof(m_hideInModeler), m_hideInModeler);
            xs.WriteString(xe, nameof(m_label), m_label);
            xs.WriteString(xe, nameof(m_group), m_group);
            xs.WriteString(xe, nameof(m_hideBaseClassMembers), m_hideBaseClassMembers);
            xs.WriteBoolean(xe, nameof(m_endGroup), m_endGroup);
            xs.WriteBoolean(xe, nameof(m_endGroup2), m_endGroup2);
            xs.WriteBoolean(xe, nameof(m_advanced), m_advanced);
        }
    }
}

