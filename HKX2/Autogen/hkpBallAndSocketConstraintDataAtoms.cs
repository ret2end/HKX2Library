using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBallAndSocketConstraintDataAtoms Signatire: 0xc73dcaf9 size: 80 flags: FLAGS_NONE

    // m_pivots m_class: hkpSetLocalTranslationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_setupStabilization m_class: hkpSetupStabilizationAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_ballSocket m_class: hkpBallSocketConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpBallAndSocketConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTranslationsConstraintAtom/*struct void*/ m_pivots;
        public hkpSetupStabilizationAtom/*struct void*/ m_setupStabilization;
        public hkpBallSocketConstraintAtom/*struct void*/ m_ballSocket;

        public uint Signature => 0xc73dcaf9;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pivots = new hkpSetLocalTranslationsConstraintAtom();
            m_pivots.Read(des,br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des,br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_pivots.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_ballSocket.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

