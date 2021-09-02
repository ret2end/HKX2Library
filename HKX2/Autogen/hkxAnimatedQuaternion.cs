using System.Collections.Generic;

namespace HKX2
{
    public class hkxAnimatedQuaternion : hkReferencedObject
    {
        public List<float> m_quaternions;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_quaternions = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_quaternions);
        }
    }
}