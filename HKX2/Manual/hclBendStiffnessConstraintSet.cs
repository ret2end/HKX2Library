using System.Collections.Generic;

namespace HKX2
{
    public class hclBendStiffnessConstraintSet : hclConstraintSet
    {
        public List<hclBendStiffnessConstraintSetLink> m_links;
        public bool m_useRestPoseConfig;
        public override uint Signature => 0x11315F09;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_links = des.ReadClassArray<hclBendStiffnessConstraintSetLink>(br);
            m_useRestPoseConfig = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_links);
            bw.WriteBoolean(m_useRestPoseConfig);
            bw.WriteByte(0);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}