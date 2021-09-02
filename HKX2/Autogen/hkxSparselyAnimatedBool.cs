using System.Collections.Generic;

namespace HKX2
{
    public class hkxSparselyAnimatedBool : hkReferencedObject
    {
        public List<bool> m_bools;
        public List<float> m_times;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bools = des.ReadBooleanArray(br);
            m_times = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteBooleanArray(bw, m_bools);
            s.WriteSingleArray(bw, m_times);
        }
    }
}