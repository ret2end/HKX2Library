using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // BSBoneSwitchGenerator Signatire: 0xf33d3eea size: 112 flags: FLAGS_NONE

    // m_pDefaultGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_ChildrenA m_class: BSBoneSwitchGeneratorBoneData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    public partial class BSBoneSwitchGenerator : hkbGenerator
    {
        public hkbGenerator m_pDefaultGenerator;
        public List<BSBoneSwitchGeneratorBoneData> m_ChildrenA = new List<BSBoneSwitchGeneratorBoneData>();

        public override uint Signature => 0xf33d3eea;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_pDefaultGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_ChildrenA = des.ReadClassPointerArray<BSBoneSwitchGeneratorBoneData>(br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pDefaultGenerator);
            s.WriteClassPointerArray<BSBoneSwitchGeneratorBoneData>(bw, m_ChildrenA);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_pDefaultGenerator = xd.ReadClassPointer<hkbGenerator>(xe, nameof(m_pDefaultGenerator));
            m_ChildrenA = xd.ReadClassPointerArray<BSBoneSwitchGeneratorBoneData>(xe, nameof(m_ChildrenA));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_pDefaultGenerator), m_pDefaultGenerator);
            xs.WriteClassPointerArray<BSBoneSwitchGeneratorBoneData>(xe, nameof(m_ChildrenA), m_ChildrenA);
        }
    }
}

