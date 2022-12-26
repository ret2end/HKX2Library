using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBlendingTransitionEffect Signatire: 0xfd8584fe size: 144 flags: FLAGS_NONE

    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_toGeneratorStartTimeFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT16 arrSize: 0 offset: 88 flags:  enum: FlagBits
    // m_endMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 90 flags:  enum: EndMode
    // m_blendCurve m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 91 flags:  enum: BlendCurve
    // m_fromGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_toGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_characterPoseAtBeginningOfTransition m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timeRemaining m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 128 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timeInTransition m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_applySelfTransition m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 136 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_initializeCharacterPose m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 137 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbBlendingTransitionEffect : hkbTransitionEffect
    {

        public float m_duration;
        public float m_toGeneratorStartTimeFraction;
        public ushort m_flags;
        public sbyte m_endMode;
        public sbyte m_blendCurve;
        public dynamic /* POINTER VOID */ m_fromGenerator;
        public dynamic /* POINTER VOID */ m_toGenerator;
        public List<ulong> m_characterPoseAtBeginningOfTransition;
        public float m_timeRemaining;
        public float m_timeInTransition;
        public bool m_applySelfTransition;
        public bool m_initializeCharacterPose;

        public override uint Signature => 0xfd8584fe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_duration = br.ReadSingle();
            m_toGeneratorStartTimeFraction = br.ReadSingle();
            m_flags = br.ReadUInt16();
            m_endMode = br.ReadSByte();
            m_blendCurve = br.ReadSByte();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_fromGenerator POINTER VOID */
            des.ReadEmptyPointer(br);/* m_toGenerator POINTER VOID */
            des.ReadEmptyArray(br); //m_characterPoseAtBeginningOfTransition
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
            bw.WriteSingle(m_duration);
            bw.WriteSingle(m_toGeneratorStartTimeFraction);
            bw.WriteUInt16(m_flags);
            s.WriteSByte(bw, m_endMode);
            s.WriteSByte(bw, m_blendCurve);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_fromGenerator POINTER VOID */
            s.WriteVoidPointer(bw);/* m_toGenerator POINTER VOID */
            s.WriteVoidArray(bw); // m_characterPoseAtBeginningOfTransition
            bw.WriteSingle(m_timeRemaining);
            bw.WriteSingle(m_timeInTransition);
            bw.WriteBoolean(m_applySelfTransition);
            bw.WriteBoolean(m_initializeCharacterPose);
            bw.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

