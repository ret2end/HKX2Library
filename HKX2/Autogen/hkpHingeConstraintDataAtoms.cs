using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpHingeConstraintDataAtoms Signatire: 0x6958371c size: 192 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_2dAng m_class: hkp2dAngConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 164 flags:  enum: 
    
    public class hkpHingeConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpSetupStabilizationAtom/*struct void*/ m_setupStabilization;
        public hkp2dAngConstraintAtom/*struct void*/ m_2dAng;
        public hkpBallSocketConstraintAtom/*struct void*/ m_ballSocket;

        public uint Signature => 0x6958371c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des,br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des,br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des,br);
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_2dAng.Write(s, bw);
            m_ballSocket.Write(s, bw);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

