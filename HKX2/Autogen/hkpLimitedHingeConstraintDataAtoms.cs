using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLimitedHingeConstraintDataAtoms Signatire: 0x54c7715b size: 240 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_angMotor m_class: hkpAngMotorConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_angFriction m_class: hkpAngFrictionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_angLimit m_class: hkpAngLimitConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 196 flags:  enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 212 flags:  enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 216 flags:  enum: 
    
    public class hkpLimitedHingeConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpSetupStabilizationAtom/*struct void*/ m_setupStabilization;
        public hkpAngMotorConstraintAtom/*struct void*/ m_angMotor;
        public hkpAngFrictionConstraintAtom/*struct void*/ m_angFriction;
        public hkpAngLimitConstraintAtom/*struct void*/ m_angLimit;
        public hkp2dAngConstraintAtom/*struct void*/ m_2dAng;
        public hkpBallSocketConstraintAtom/*struct void*/ m_ballSocket;

        public uint Signature => 0x54c7715b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des,br);
            m_angMotor = new hkpAngMotorConstraintAtom();
            m_angMotor.Read(des,br);
            m_angFriction = new hkpAngFrictionConstraintAtom();
            m_angFriction.Read(des,br);
            m_angLimit = new hkpAngLimitConstraintAtom();
            m_angLimit.Read(des,br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des,br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des,br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_angMotor.Write(s, bw);
            m_angFriction.Write(s, bw);
            m_angLimit.Write(s, bw);
            m_2dAng.Write(s, bw);
            m_ballSocket.Write(s, bw);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

