using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRagdollConstraintDataAtoms Signatire: 0xeed76b00 size: 352 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_ragdollMotors m_class: hkpRagdollMotorConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_angFriction m_class: hkpAngFrictionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 256 flags:  enum: 
    // m_twistLimit m_class: hkpTwistLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 268 flags:  enum: 
    // m_coneLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 288 flags:  enum: 
    // m_planesLimit m_class: hkpConeLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 308 flags:  enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 328 flags:  enum: 
    
    public class hkpRagdollConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpSetupStabilizationAtom/*struct void*/ m_setupStabilization;
        public hkpRagdollMotorConstraintAtom/*struct void*/ m_ragdollMotors;
        public hkpAngFrictionConstraintAtom/*struct void*/ m_angFriction;
        public hkpTwistLimitConstraintAtom/*struct void*/ m_twistLimit;
        public hkpConeLimitConstraintAtom/*struct void*/ m_coneLimit;
        public hkpConeLimitConstraintAtom/*struct void*/ m_planesLimit;
        public hkpBallSocketConstraintAtom/*struct void*/ m_ballSocket;

        public uint Signature => 0xeed76b00;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des,br);
            m_ragdollMotors = new hkpRagdollMotorConstraintAtom();
            m_ragdollMotors.Read(des,br);
            m_angFriction = new hkpAngFrictionConstraintAtom();
            m_angFriction.Read(des,br);
            m_twistLimit = new hkpTwistLimitConstraintAtom();
            m_twistLimit.Read(des,br);
            m_coneLimit = new hkpConeLimitConstraintAtom();
            m_coneLimit.Read(des,br);
            m_planesLimit = new hkpConeLimitConstraintAtom();
            m_planesLimit.Read(des,br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des,br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

