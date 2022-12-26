using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkGains Signatire: 0xa681b7f0 size: 48 flags: FLAGS_NONE

    // m_onOffGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_groundAscendingGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_groundDescendingGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_footPlantedGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_footRaisedGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_footUnlockGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_worldFromModelFeedbackGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_errorUpDownBias m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_alignWorldFromModelGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_hipOrientationGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_maxKneeAngleDifference m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_ankleOrientationGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    
    public class hkbFootIkGains : IHavokObject
    {

        public float m_onOffGain;
        public float m_groundAscendingGain;
        public float m_groundDescendingGain;
        public float m_footPlantedGain;
        public float m_footRaisedGain;
        public float m_footUnlockGain;
        public float m_worldFromModelFeedbackGain;
        public float m_errorUpDownBias;
        public float m_alignWorldFromModelGain;
        public float m_hipOrientationGain;
        public float m_maxKneeAngleDifference;
        public float m_ankleOrientationGain;

        public uint Signature => 0xa681b7f0;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_onOffGain = br.ReadSingle();
            m_groundAscendingGain = br.ReadSingle();
            m_groundDescendingGain = br.ReadSingle();
            m_footPlantedGain = br.ReadSingle();
            m_footRaisedGain = br.ReadSingle();
            m_footUnlockGain = br.ReadSingle();
            m_worldFromModelFeedbackGain = br.ReadSingle();
            m_errorUpDownBias = br.ReadSingle();
            m_alignWorldFromModelGain = br.ReadSingle();
            m_hipOrientationGain = br.ReadSingle();
            m_maxKneeAngleDifference = br.ReadSingle();
            m_ankleOrientationGain = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_onOffGain);
            bw.WriteSingle(m_groundAscendingGain);
            bw.WriteSingle(m_groundDescendingGain);
            bw.WriteSingle(m_footPlantedGain);
            bw.WriteSingle(m_footRaisedGain);
            bw.WriteSingle(m_footUnlockGain);
            bw.WriteSingle(m_worldFromModelFeedbackGain);
            bw.WriteSingle(m_errorUpDownBias);
            bw.WriteSingle(m_alignWorldFromModelGain);
            bw.WriteSingle(m_hipOrientationGain);
            bw.WriteSingle(m_maxKneeAngleDifference);
            bw.WriteSingle(m_ankleOrientationGain);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

