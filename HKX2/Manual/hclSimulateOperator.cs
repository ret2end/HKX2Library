using System.Collections.Generic;

namespace HKX2
{
    public class hclSimulateOperator : hclOperator
    {
        public bool m_adaptConstraintStiffness;
        public List<int> m_constraintExecution;
        public int m_numberOfSolveIterations;

        public uint m_simClothIndex;
        public uint m_subSteps;
        public override uint Signature => 0x75C72F0F;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            m_simClothIndex = br.ReadUInt32();
            m_subSteps = br.ReadUInt32();
            m_numberOfSolveIterations = br.ReadInt32();
            m_constraintExecution = des.ReadInt32Array(br);
            m_adaptConstraintStiffness = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteUInt32(m_simClothIndex);
            bw.WriteUInt32(m_subSteps);
            bw.WriteInt32(m_numberOfSolveIterations);
            s.WriteInt32Array(bw, m_constraintExecution);
            bw.WriteBoolean(m_adaptConstraintStiffness);
            bw.WriteByte(0);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}