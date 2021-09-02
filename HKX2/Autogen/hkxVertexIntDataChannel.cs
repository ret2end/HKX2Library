using System.Collections.Generic;

namespace HKX2
{
    public class hkxVertexIntDataChannel : hkReferencedObject
    {
        public List<int> m_perVertexInts;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_perVertexInts = des.ReadInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt32Array(bw, m_perVertexInts);
        }
    }
}