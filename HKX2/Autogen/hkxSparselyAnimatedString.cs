using System.Collections.Generic;

namespace HKX2
{
    public class hkxSparselyAnimatedString : hkReferencedObject
    {
        public List<string> m_strings;
        public List<float> m_times;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_strings = des.ReadStringPointerArray(br);
            m_times = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_strings);
            s.WriteSingleArray(bw, m_times);
        }
    }
}