using System.Collections.Generic;

namespace HKX2
{
    public enum PpivResult
    {
        PPIV_RESULT_SUCCESS = 0,
        PPIV_RESULT_HIT_PATH_END = 1,
        PPIV_RESULT_INVALID_PATH = 2
    }

    public class hkaiEdgePath : hkReferencedObject
    {
        public float m_characterRadius;
        public List<int> m_edgeData;
        public int m_edgeDataStriding;

        public List<hkaiEdgePathEdge> m_edges;
        public float m_leftTurnRadius;
        public float m_rightTurnRadius;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_edges = des.ReadClassArray<hkaiEdgePathEdge>(br);
            m_edgeData = des.ReadInt32Array(br);
            m_edgeDataStriding = br.ReadInt32();
            m_leftTurnRadius = br.ReadSingle();
            m_rightTurnRadius = br.ReadSingle();
            m_characterRadius = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_edges);
            s.WriteInt32Array(bw, m_edgeData);
            bw.WriteInt32(m_edgeDataStriding);
            bw.WriteSingle(m_leftTurnRadius);
            bw.WriteSingle(m_rightTurnRadius);
            bw.WriteSingle(m_characterRadius);
        }
    }
}