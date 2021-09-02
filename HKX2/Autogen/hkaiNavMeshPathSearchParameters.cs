using System.Numerics;

namespace HKX2
{
    public enum OutputPathFlags
    {
        OUTPUT_PATH_SMOOTHED = 1,
        OUTPUT_PATH_PROJECTED = 2,
        OUTPUT_PATH_COMPUTE_NORMALS = 4
    }

    public class hkaiNavMeshPathSearchParameters : IHavokObject
    {
        public enum LineOfSightFlags
        {
            NO_LINE_OF_SIGHT_CHECK = 0,
            EARLY_OUT_IF_NO_COST_MODIFIER = 1,
            HANDLE_INTERNAL_VERTICES = 2,
            EARLY_OUT_ALWAYS = 4
        }

        public hkaiSearchParametersBufferSizes m_bufferSizes;
        public float m_heuristicWeight;
        public hkaiSearchParametersBufferSizes m_hierarchyBufferSizes;
        public byte m_lineOfSightFlags;
        public float m_maximumPathLength;
        public byte m_outputPathFlags;
        public bool m_projectedRadiusCheck;
        public float m_searchCapsuleRadius;
        public float m_searchSphereRadius;
        public float m_simpleRadiusThreshold;

        public Vector4 m_up;
        public bool m_useGrandparentDistanceCalculation;
        public bool m_useHierarchicalHeuristic;
        public bool m_validateInputs;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_up = des.ReadVector4(br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_validateInputs = br.ReadBoolean();
            m_outputPathFlags = br.ReadByte();
            m_lineOfSightFlags = br.ReadByte();
            m_useHierarchicalHeuristic = br.ReadBoolean();
            m_projectedRadiusCheck = br.ReadBoolean();
            m_useGrandparentDistanceCalculation = br.ReadBoolean();
            br.ReadUInt16();
            m_heuristicWeight = br.ReadSingle();
            m_simpleRadiusThreshold = br.ReadSingle();
            m_maximumPathLength = br.ReadSingle();
            m_searchSphereRadius = br.ReadSingle();
            m_searchCapsuleRadius = br.ReadSingle();
            m_bufferSizes = new hkaiSearchParametersBufferSizes();
            m_bufferSizes.Read(des, br);
            m_hierarchyBufferSizes = new hkaiSearchParametersBufferSizes();
            m_hierarchyBufferSizes.Read(des, br);
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_up);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteBoolean(m_validateInputs);
            bw.WriteByte(m_outputPathFlags);
            bw.WriteByte(m_lineOfSightFlags);
            bw.WriteBoolean(m_useHierarchicalHeuristic);
            bw.WriteBoolean(m_projectedRadiusCheck);
            bw.WriteBoolean(m_useGrandparentDistanceCalculation);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_heuristicWeight);
            bw.WriteSingle(m_simpleRadiusThreshold);
            bw.WriteSingle(m_maximumPathLength);
            bw.WriteSingle(m_searchSphereRadius);
            bw.WriteSingle(m_searchCapsuleRadius);
            m_bufferSizes.Write(s, bw);
            m_hierarchyBufferSizes.Write(s, bw);
            bw.WriteUInt32(0);
        }
    }
}