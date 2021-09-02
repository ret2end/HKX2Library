using System.Collections.Generic;

namespace HKX2
{
    public class hkaiVolumePathfindingUtilFindPathOutput : hkReferencedObject
    {
        public hkaiAstarOutputParameters m_outputParameters;
        public List<hkaiPathPathPoint> m_pathOut;

        public List<uint> m_visitedCells;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_visitedCells = des.ReadUInt32Array(br);
            m_pathOut = des.ReadClassArray<hkaiPathPathPoint>(br);
            m_outputParameters = new hkaiAstarOutputParameters();
            m_outputParameters.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_visitedCells);
            s.WriteClassArray(bw, m_pathOut);
            m_outputParameters.Write(s, bw);
        }
    }
}