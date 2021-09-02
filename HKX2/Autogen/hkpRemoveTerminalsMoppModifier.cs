using System.Collections.Generic;

namespace HKX2
{
    public class hkpRemoveTerminalsMoppModifier : hkReferencedObject
    {
        public List<uint> m_removeInfo;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_removeInfo = des.ReadUInt32Array(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteUInt32Array(bw, m_removeInfo);
            bw.WriteUInt64(0);
        }
    }
}