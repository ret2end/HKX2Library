using System.Collections.Generic;

namespace HKX2
{
    public class hclObjectSpaceDeformer : IHavokObject
    {
        public enum ControlByte
        {
            FOUR_BLEND = 0,
            THREE_BLEND = 1,
            TWO_BLEND = 2,
            ONE_BLEND = 3,
            NEXT_SPU_BATCH = 4,
            EIGHT_BLEND = 5,
            SEVEN_BLEND = 6,
            SIX_BLEND = 7,
            FIVE_BLEND = 8
        }

        public ushort m_batchSizeSpu;
        public List<byte> m_controlBytes;

        public List<hclObjectSpaceDeformerEightBlendEntryBlock> m_eightBlendEntries;
        public ushort m_endVertexIndex;
        public List<hclObjectSpaceDeformerFiveBlendEntryBlock> m_fiveBlendEntries;
        public List<hclObjectSpaceDeformerFourBlendEntryBlock> m_fourBlendEntries;
        public List<hclObjectSpaceDeformerOneBlendEntryBlock> m_oneBlendEntries;
        public bool m_partialWrite;
        public List<hclObjectSpaceDeformerSevenBlendEntryBlock> m_sevenBlendEntries;
        public List<hclObjectSpaceDeformerSixBlendEntryBlock> m_sixBlendEntries;
        public ushort m_startVertexIndex;
        public List<hclObjectSpaceDeformerThreeBlendEntryBlock> m_threeBlendEntries;
        public List<hclObjectSpaceDeformerTwoBlendEntryBlock> m_twoBlendEntries;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_eightBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerEightBlendEntryBlock>(br);
            m_sevenBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerSevenBlendEntryBlock>(br);
            m_sixBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerSixBlendEntryBlock>(br);
            m_fiveBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerFiveBlendEntryBlock>(br);
            m_fourBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerFourBlendEntryBlock>(br);
            m_threeBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerThreeBlendEntryBlock>(br);
            m_twoBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerTwoBlendEntryBlock>(br);
            m_oneBlendEntries = des.ReadClassArray<hclObjectSpaceDeformerOneBlendEntryBlock>(br);
            m_controlBytes = des.ReadByteArray(br);
            m_startVertexIndex = br.ReadUInt16();
            m_endVertexIndex = br.ReadUInt16();
            m_batchSizeSpu = br.ReadUInt16();
            m_partialWrite = br.ReadBoolean();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_eightBlendEntries);
            s.WriteClassArray(bw, m_sevenBlendEntries);
            s.WriteClassArray(bw, m_sixBlendEntries);
            s.WriteClassArray(bw, m_fiveBlendEntries);
            s.WriteClassArray(bw, m_fourBlendEntries);
            s.WriteClassArray(bw, m_threeBlendEntries);
            s.WriteClassArray(bw, m_twoBlendEntries);
            s.WriteClassArray(bw, m_oneBlendEntries);
            s.WriteByteArray(bw, m_controlBytes);
            bw.WriteUInt16(m_startVertexIndex);
            bw.WriteUInt16(m_endVertexIndex);
            bw.WriteUInt16(m_batchSizeSpu);
            bw.WriteBoolean(m_partialWrite);
            bw.WriteByte(0);
        }
    }
}