using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpWorldObject Signatire: 0x49fb6f2e size: 208 flags: FLAGS_NONE

    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_collidable m_class: hkpLinkedCollidable Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_multiThreadCheck m_class: hkMultiThreadCheck Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_properties m_class: hkpProperty Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    // m_treeData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 200 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpWorldObject : hkReferencedObject
    {
        public dynamic m_world;
        public ulong m_userData;
        public hkpLinkedCollidable m_collidable = new hkpLinkedCollidable();
        public hkMultiThreadCheck m_multiThreadCheck = new hkMultiThreadCheck();
        public string m_name;
        public List<hkpProperty> m_properties = new List<hkpProperty>();
        public dynamic m_treeData;

        public override uint Signature => 0x49fb6f2e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyPointer(br);
            m_userData = br.ReadUInt64();
            m_collidable = new hkpLinkedCollidable();
            m_collidable.Read(des, br);
            m_multiThreadCheck = new hkMultiThreadCheck();
            m_multiThreadCheck.Read(des, br);
            br.Position += 4;
            m_name = des.ReadStringPointer(br);
            m_properties = des.ReadClassArray<hkpProperty>(br);
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidPointer(bw);
            bw.WriteUInt64(m_userData);
            m_collidable.Write(s, bw);
            m_multiThreadCheck.Write(s, bw);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray<hkpProperty>(bw, m_properties);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_world = default;
            m_userData = xd.ReadUInt64(xe, nameof(m_userData));
            m_collidable = xd.ReadClass<hkpLinkedCollidable>(xe, nameof(m_collidable));
            m_multiThreadCheck = xd.ReadClass<hkMultiThreadCheck>(xe, nameof(m_multiThreadCheck));
            m_name = xd.ReadString(xe, nameof(m_name));
            m_properties = xd.ReadClassArray<hkpProperty>(xe, nameof(m_properties));
            m_treeData = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_world));
            xs.WriteNumber(xe, nameof(m_userData), m_userData);
            xs.WriteClass<hkpLinkedCollidable>(xe, nameof(m_collidable), m_collidable);
            xs.WriteClass<hkMultiThreadCheck>(xe, nameof(m_multiThreadCheck), m_multiThreadCheck);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassArray<hkpProperty>(xe, nameof(m_properties), m_properties);
            xs.WriteSerializeIgnored(xe, nameof(m_treeData));
        }
    }
}

