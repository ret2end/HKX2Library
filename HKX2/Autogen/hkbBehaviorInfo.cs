using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorInfo Signatire: 0xf7645395 size: 48 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_data m_class: hkbBehaviorGraphData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_idToNamePairs m_class: hkbBehaviorInfoIdToNamePair Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbBehaviorInfo : hkReferencedObject
    {
        public ulong m_characterId;
        public hkbBehaviorGraphData m_data;
        public List<hkbBehaviorInfoIdToNamePair> m_idToNamePairs = new List<hkbBehaviorInfoIdToNamePair>();

        public override uint Signature => 0xf7645395;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_data = des.ReadClassPointer<hkbBehaviorGraphData>(br);
            m_idToNamePairs = des.ReadClassArray<hkbBehaviorInfoIdToNamePair>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteClassPointer(bw, m_data);
            s.WriteClassArray<hkbBehaviorInfoIdToNamePair>(bw, m_idToNamePairs);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_characterId = xd.ReadUInt64(xe, nameof(m_characterId));
            m_data = xd.ReadClassPointer<hkbBehaviorGraphData>(xe, nameof(m_data));
            m_idToNamePairs = xd.ReadClassArray<hkbBehaviorInfoIdToNamePair>(xe, nameof(m_idToNamePairs));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteClassPointer(xe, nameof(m_data), m_data);
            xs.WriteClassArray<hkbBehaviorInfoIdToNamePair>(xe, nameof(m_idToNamePairs), m_idToNamePairs);
        }
    }
}

