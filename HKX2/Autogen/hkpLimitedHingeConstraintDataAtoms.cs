using System.Xml.Linq;

namespace HKX2
{
    // hkpLimitedHingeConstraintDataAtoms Signatire: 0x54c7715b size: 240 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_angMotor m_class: hkpAngMotorConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_angFriction m_class: hkpAngFrictionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    // m_angLimit m_class: hkpAngLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 212 flags: FLAGS_NONE enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 216 flags: FLAGS_NONE enum: 
    public partial class hkpLimitedHingeConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public hkpSetupStabilizationAtom m_setupStabilization;
        public hkpAngMotorConstraintAtom m_angMotor;
        public hkpAngFrictionConstraintAtom m_angFriction;
        public hkpAngLimitConstraintAtom m_angLimit;
        public hkp2dAngConstraintAtom m_2dAng;
        public hkpBallSocketConstraintAtom m_ballSocket;

        public virtual uint Signature => 0x54c7715b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des, br);
            m_angMotor = new hkpAngMotorConstraintAtom();
            m_angMotor.Read(des, br);
            m_angFriction = new hkpAngFrictionConstraintAtom();
            m_angFriction.Read(des, br);
            m_angLimit = new hkpAngLimitConstraintAtom();
            m_angLimit.Read(des, br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des, br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des, br);
            br.Position += 8;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_angMotor.Write(s, bw);
            m_angFriction.Write(s, bw);
            m_angLimit.Write(s, bw);
            m_2dAng.Write(s, bw);
            m_ballSocket.Write(s, bw);
            bw.Position += 8;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTransformsConstraintAtom>(xe, nameof(m_transforms), m_transforms);
            xs.WriteClass<hkpSetupStabilizationAtom>(xe, nameof(m_setupStabilization), m_setupStabilization);
            xs.WriteClass<hkpAngMotorConstraintAtom>(xe, nameof(m_angMotor), m_angMotor);
            xs.WriteClass<hkpAngFrictionConstraintAtom>(xe, nameof(m_angFriction), m_angFriction);
            xs.WriteClass<hkpAngLimitConstraintAtom>(xe, nameof(m_angLimit), m_angLimit);
            xs.WriteClass<hkp2dAngConstraintAtom>(xe, nameof(m_2dAng), m_2dAng);
            xs.WriteClass<hkpBallSocketConstraintAtom>(xe, nameof(m_ballSocket), m_ballSocket);
        }
    }
}

