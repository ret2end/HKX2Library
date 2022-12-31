using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxSparselyAnimatedInt Signatire: 0xca961951 size: 48 flags: FLAGS_NONE

    // m_ints m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_times m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkxSparselyAnimatedInt : hkReferencedObject
    {
        public List<int> m_ints;
        public List<float> m_times;

        public override uint Signature => 0xca961951;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_ints = des.ReadInt32Array(br);
            m_times = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt32Array(bw, m_ints);
            s.WriteSingleArray(bw, m_times);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_ints), m_ints);
            xs.WriteFloatArray(xe, nameof(m_times), m_times);
        }
    }
}

