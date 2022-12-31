using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbManualSelectorGenerator Signatire: 0xd932fab8 size: 96 flags: FLAGS_NONE

    // m_generators m_class: hkbGenerator Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_selectedGeneratorIndex m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_currentGeneratorIndex m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 89 flags: FLAGS_NONE enum: 
    public partial class hkbManualSelectorGenerator : hkbGenerator
    {
        public List<hkbGenerator> m_generators;
        public sbyte m_selectedGeneratorIndex;
        public sbyte m_currentGeneratorIndex;

        public override uint Signature => 0xd932fab8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_generators = des.ReadClassPointerArray<hkbGenerator>(br);
            m_selectedGeneratorIndex = br.ReadSByte();
            m_currentGeneratorIndex = br.ReadSByte();
            br.Position += 6;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkbGenerator>(bw, m_generators);
            bw.WriteSByte(m_selectedGeneratorIndex);
            bw.WriteSByte(m_currentGeneratorIndex);
            bw.Position += 6;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkbGenerator>(xe, nameof(m_generators), m_generators);
            xs.WriteNumber(xe, nameof(m_selectedGeneratorIndex), m_selectedGeneratorIndex);
            xs.WriteNumber(xe, nameof(m_currentGeneratorIndex), m_currentGeneratorIndex);
        }
    }
}

