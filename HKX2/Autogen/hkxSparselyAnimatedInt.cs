using System.Collections.Generic;

namespace HKX2
{
    public class hkxSparselyAnimatedInt : hkReferencedObject
    {
        public List<int> m_ints;
        public List<float> m_times;
        public override uint Signature => 0;

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
    }
}