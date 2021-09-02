using System.Collections.Generic;

namespace HKX2
{
    public enum VertexFloatDimensions
    {
        FLOAT = 0,
        DISTANCE = 1,
        ANGLE = 2
    }

    public class hkxVertexFloatDataChannel : hkReferencedObject
    {
        public VertexFloatDimensions m_dimensions;

        public List<float> m_perVertexFloats;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_perVertexFloats = des.ReadSingleArray(br);
            m_dimensions = (VertexFloatDimensions) br.ReadByte();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_perVertexFloats);
            bw.WriteByte((byte) m_dimensions);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}