namespace HKX2
{
    public class hkaiPathFollowingProperties : hkReferencedObject
    {
        public float m_desiredSpeedAtEnd;
        public float m_goalDistTolerance;
        public int m_incompleteRepathSegments;
        public bool m_pullThroughInternalVertices;
        public bool m_repairPaths;

        public float m_repathDistance;
        public float m_searchPathLimit;
        public bool m_setManualControlOnUserEdges;
        public float m_userEdgeTolerance;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_repathDistance = br.ReadSingle();
            m_incompleteRepathSegments = br.ReadInt32();
            m_searchPathLimit = br.ReadSingle();
            m_desiredSpeedAtEnd = br.ReadSingle();
            m_goalDistTolerance = br.ReadSingle();
            m_userEdgeTolerance = br.ReadSingle();
            m_repairPaths = br.ReadBoolean();
            m_setManualControlOnUserEdges = br.ReadBoolean();
            m_pullThroughInternalVertices = br.ReadBoolean();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_repathDistance);
            bw.WriteInt32(m_incompleteRepathSegments);
            bw.WriteSingle(m_searchPathLimit);
            bw.WriteSingle(m_desiredSpeedAtEnd);
            bw.WriteSingle(m_goalDistTolerance);
            bw.WriteSingle(m_userEdgeTolerance);
            bw.WriteBoolean(m_repairPaths);
            bw.WriteBoolean(m_setManualControlOnUserEdges);
            bw.WriteBoolean(m_pullThroughInternalVertices);
            bw.WriteByte(0);
        }
    }
}