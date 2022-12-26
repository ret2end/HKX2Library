using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBlendingTransitionEffectInternalState Signatire: 0xb18c70c2 size: 48 flags: FLAGS_NONE

    // m_characterPoseAtBeginningOfTransition m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 16 flags:  enum: 
    // m_timeRemaining m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_timeInTransition m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_applySelfTransition m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_initializeCharacterPose m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 41 flags:  enum: 
    
    public class hkbBlendingTransitionEffectInternalState : hkReferencedObject
    {

        public List<Matrix4x4> m_characterPoseAtBeginningOfTransition;
        public float m_timeRemaining;
        public float m_timeInTransition;
        public bool m_applySelfTransition;
        public bool m_initializeCharacterPose;

        public override uint Signature => 0xb18c70c2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterPoseAtBeginningOfTransition = des.ReadQSTransformArray(br);
            m_timeRemaining = br.ReadSingle();
            m_timeInTransition = br.ReadSingle();
            m_applySelfTransition = br.ReadBoolean();
            m_initializeCharacterPose = br.ReadBoolean();
            br.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQSTransformArray(bw, m_characterPoseAtBeginningOfTransition);
            bw.WriteSingle(m_timeRemaining);
            bw.WriteSingle(m_timeInTransition);
            bw.WriteBoolean(m_applySelfTransition);
            bw.WriteBoolean(m_initializeCharacterPose);
            bw.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

