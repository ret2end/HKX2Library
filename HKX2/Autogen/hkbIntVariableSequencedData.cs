using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbIntVariableSequencedData Signatire: 0x7bfc518a size: 40 flags: FLAGS_NONE

    // m_samples m_class: hkbIntVariableSequencedDataSample Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_variableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbIntVariableSequencedData : hkbSequencedData
    {
        public List<hkbIntVariableSequencedDataSample> m_samples;
        public int m_variableIndex;

        public override uint Signature => 0x7bfc518a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_samples = des.ReadClassArray<hkbIntVariableSequencedDataSample>(br);
            m_variableIndex = br.ReadInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbIntVariableSequencedDataSample>(bw, m_samples);
            bw.WriteInt32(m_variableIndex);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbIntVariableSequencedDataSample>(xe, nameof(m_samples), m_samples);
            xs.WriteNumber(xe, nameof(m_variableIndex), m_variableIndex);
        }
    }
}

