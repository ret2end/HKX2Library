using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpPhysicsData Signatire: 0xc2a461e4 size: 40 flags: FLAGS_NONE

    // m_worldCinfo m_class: hkpWorldCinfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_systems m_class: hkpPhysicsSystem Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkpPhysicsData : hkReferencedObject
    {
        public hkpWorldCinfo m_worldCinfo;
        public List<hkpPhysicsSystem> m_systems = new List<hkpPhysicsSystem>();

        public override uint Signature => 0xc2a461e4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_worldCinfo = des.ReadClassPointer<hkpWorldCinfo>(br);
            m_systems = des.ReadClassPointerArray<hkpPhysicsSystem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_worldCinfo);
            s.WriteClassPointerArray<hkpPhysicsSystem>(bw, m_systems);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_worldCinfo = xd.ReadClassPointer<hkpWorldCinfo>(xe, nameof(m_worldCinfo));
            m_systems = xd.ReadClassPointerArray<hkpPhysicsSystem>(xe, nameof(m_systems));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_worldCinfo), m_worldCinfo);
            xs.WriteClassPointerArray<hkpPhysicsSystem>(xe, nameof(m_systems), m_systems);
        }
    }
}

