using System.Collections.Generic;

namespace HKX2
{
    public class hkxBlob : hkReferencedObject
    {
        public List<byte> m_data;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_data = des.ReadByteArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteByteArray(bw, m_data);
        }
    }
}