using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpAabbPhantom Signatire: 0x2c5189dd size: 304 flags: FLAGS_NONE

    // m_aabb m_class: hkAabb Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 240 flags: FLAGS_NONE enum: 
    // m_overlappingCollidables m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 272 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_orderDirty m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 288 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpAabbPhantom : hkpPhantom
    {
        public hkAabb m_aabb { set; get; } = new();
        public IList<object> m_overlappingCollidables { set; get; } = new List<object>();
        private bool m_orderDirty { set; get; } = default;

        public override uint Signature => 0x2c5189dd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_aabb.Read(des, br);
            des.ReadEmptyArray(br);
            m_orderDirty = br.ReadBoolean();
            br.Position += 15;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_aabb.Write(s, bw);
            s.WriteVoidArray(bw);
            bw.WriteBoolean(m_orderDirty);
            bw.Position += 15;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_aabb = xd.ReadClass<hkAabb>(xe, nameof(m_aabb));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkAabb>(xe, nameof(m_aabb), m_aabb);
            xs.WriteSerializeIgnored(xe, nameof(m_overlappingCollidables));
            xs.WriteSerializeIgnored(xe, nameof(m_orderDirty));
        }
    }
}

