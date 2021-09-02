namespace HKX2
{
    public class hkpBallAndSocketConstraintDataAtoms : IHavokObject
    {
        public hkpBallSocketConstraintAtom m_ballSocket;

        public hkpSetLocalTranslationsConstraintAtom m_pivots;
        public hkpSetupStabilizationAtom m_setupStabilization;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pivots = new hkpSetLocalTranslationsConstraintAtom();
            m_pivots.Read(des, br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des, br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_pivots.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_ballSocket.Write(s, bw);
        }
    }
}