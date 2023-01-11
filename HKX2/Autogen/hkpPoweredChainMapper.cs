using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpPoweredChainMapper Signatire: 0x7a77ef5 size: 64 flags: FLAGS_NONE

    // m_links m_class: hkpPoweredChainMapperLinkInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_targets m_class: hkpPoweredChainMapperTarget Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_chains m_class: hkpConstraintChainInstance Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpPoweredChainMapper : hkReferencedObject
    {
        public IList<hkpPoweredChainMapperLinkInfo> m_links { set; get; } = new List<hkpPoweredChainMapperLinkInfo>();
        public IList<hkpPoweredChainMapperTarget> m_targets { set; get; } = new List<hkpPoweredChainMapperTarget>();
        public IList<hkpConstraintChainInstance> m_chains { set; get; } = new List<hkpConstraintChainInstance>();

        public override uint Signature => 0x7a77ef5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_links = des.ReadClassArray<hkpPoweredChainMapperLinkInfo>(br);
            m_targets = des.ReadClassArray<hkpPoweredChainMapperTarget>(br);
            m_chains = des.ReadClassPointerArray<hkpConstraintChainInstance>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_links);
            s.WriteClassArray(bw, m_targets);
            s.WriteClassPointerArray(bw, m_chains);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_links = xd.ReadClassArray<hkpPoweredChainMapperLinkInfo>(xe, nameof(m_links));
            m_targets = xd.ReadClassArray<hkpPoweredChainMapperTarget>(xe, nameof(m_targets));
            m_chains = xd.ReadClassPointerArray<hkpConstraintChainInstance>(xe, nameof(m_chains));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkpPoweredChainMapperLinkInfo>(xe, nameof(m_links), m_links);
            xs.WriteClassArray<hkpPoweredChainMapperTarget>(xe, nameof(m_targets), m_targets);
            xs.WriteClassPointerArray<hkpConstraintChainInstance>(xe, nameof(m_chains), m_chains);
        }
    }
}

