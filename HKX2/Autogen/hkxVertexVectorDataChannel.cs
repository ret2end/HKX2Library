using System.Collections.Generic;

namespace HKX2
{
    public class hkxVertexVectorDataChannel : hkReferencedObject
    {
        public List<float> m_perVertexVectors;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_perVertexVectors = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_perVertexVectors);
        }
    }
}