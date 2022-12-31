using System.Xml.Linq;

namespace HKX2
{
    // hkpBallAndSocketConstraintDataAtoms Signatire: 0xc73dcaf9 size: 80 flags: FLAGS_NONE

    // m_pivots m_class: hkpSetLocalTranslationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpBallAndSocketConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTranslationsConstraintAtom m_pivots;
        public hkpSetupStabilizationAtom m_setupStabilization;
        public hkpBallSocketConstraintAtom m_ballSocket;

        public virtual uint Signature => 0xc73dcaf9;

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

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTranslationsConstraintAtom>(xe, nameof(m_pivots), m_pivots);
            xs.WriteClass<hkpSetupStabilizationAtom>(xe, nameof(m_setupStabilization), m_setupStabilization);
            xs.WriteClass<hkpBallSocketConstraintAtom>(xe, nameof(m_ballSocket), m_ballSocket);
        }
    }
}

