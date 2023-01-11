using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpRagdollConstraintDataAtoms Signatire: 0xeed76b00 size: 352 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_ragdollMotors m_class: hkpRagdollMotorConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_angFriction m_class: hkpAngFrictionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 256 flags: FLAGS_NONE enum: 
    // m_twistLimit m_class: hkpTwistLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 268 flags: FLAGS_NONE enum: 
    // m_coneLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 288 flags: FLAGS_NONE enum: 
    // m_planesLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 308 flags: FLAGS_NONE enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 328 flags: FLAGS_NONE enum: 
    public partial class hkpRagdollConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTransformsConstraintAtom m_transforms { set; get; } = new();
        public hkpSetupStabilizationAtom m_setupStabilization { set; get; } = new();
        public hkpRagdollMotorConstraintAtom m_ragdollMotors { set; get; } = new();
        public hkpAngFrictionConstraintAtom m_angFriction { set; get; } = new();
        public hkpTwistLimitConstraintAtom m_twistLimit { set; get; } = new();
        public hkpConeLimitConstraintAtom m_coneLimit { set; get; } = new();
        public hkpConeLimitConstraintAtom m_planesLimit { set; get; } = new();
        public hkpBallSocketConstraintAtom m_ballSocket { set; get; } = new();

        public virtual uint Signature => 0xeed76b00;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms.Read(des, br);
            m_setupStabilization.Read(des, br);
            m_ragdollMotors.Read(des, br);
            m_angFriction.Read(des, br);
            m_twistLimit.Read(des, br);
            m_coneLimit.Read(des, br);
            m_planesLimit.Read(des, br);
            m_ballSocket.Read(des, br);
            br.Position += 8;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_ragdollMotors.Write(s, bw);
            m_angFriction.Write(s, bw);
            m_twistLimit.Write(s, bw);
            m_coneLimit.Write(s, bw);
            m_planesLimit.Write(s, bw);
            m_ballSocket.Write(s, bw);
            bw.Position += 8;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_transforms = xd.ReadClass<hkpSetLocalTransformsConstraintAtom>(xe, nameof(m_transforms));
            m_setupStabilization = xd.ReadClass<hkpSetupStabilizationAtom>(xe, nameof(m_setupStabilization));
            m_ragdollMotors = xd.ReadClass<hkpRagdollMotorConstraintAtom>(xe, nameof(m_ragdollMotors));
            m_angFriction = xd.ReadClass<hkpAngFrictionConstraintAtom>(xe, nameof(m_angFriction));
            m_twistLimit = xd.ReadClass<hkpTwistLimitConstraintAtom>(xe, nameof(m_twistLimit));
            m_coneLimit = xd.ReadClass<hkpConeLimitConstraintAtom>(xe, nameof(m_coneLimit));
            m_planesLimit = xd.ReadClass<hkpConeLimitConstraintAtom>(xe, nameof(m_planesLimit));
            m_ballSocket = xd.ReadClass<hkpBallSocketConstraintAtom>(xe, nameof(m_ballSocket));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTransformsConstraintAtom>(xe, nameof(m_transforms), m_transforms);
            xs.WriteClass<hkpSetupStabilizationAtom>(xe, nameof(m_setupStabilization), m_setupStabilization);
            xs.WriteClass<hkpRagdollMotorConstraintAtom>(xe, nameof(m_ragdollMotors), m_ragdollMotors);
            xs.WriteClass<hkpAngFrictionConstraintAtom>(xe, nameof(m_angFriction), m_angFriction);
            xs.WriteClass<hkpTwistLimitConstraintAtom>(xe, nameof(m_twistLimit), m_twistLimit);
            xs.WriteClass<hkpConeLimitConstraintAtom>(xe, nameof(m_coneLimit), m_coneLimit);
            xs.WriteClass<hkpConeLimitConstraintAtom>(xe, nameof(m_planesLimit), m_planesLimit);
            xs.WriteClass<hkpBallSocketConstraintAtom>(xe, nameof(m_ballSocket), m_ballSocket);
        }
    }
}

