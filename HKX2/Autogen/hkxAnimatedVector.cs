using System.Collections.Generic;

namespace HKX2
{
    public class hkxAnimatedVector : hkReferencedObject
    {
        public Hint m_hint;

        public List<float> m_vectors;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vectors = des.ReadSingleArray(br);
            m_hint = (Hint) br.ReadByte();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_vectors);
            bw.WriteByte((byte) m_hint);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}