using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbPoseMatchingGenerator Signatire: 0x29e271b4 size: 240 flags: FLAGS_NONE

    // m_worldFromModelRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_blendSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_minSpeedToSwitch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 180 flags:  enum: 
    // m_minSwitchTimeNoError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_minSwitchTimeFullError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags:  enum: 
    // m_startPlayingEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 192 flags:  enum: 
    // m_startMatchingEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 196 flags:  enum: 
    // m_rootBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 200 flags:  enum: 
    // m_otherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 202 flags:  enum: 
    // m_anotherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 204 flags:  enum: 
    // m_pelvisIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 206 flags:  enum: 
    // m_mode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 208 flags:  enum: Mode
    // m_currentMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 212 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bestMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 216 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timeSinceBetterMatch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 220 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_error m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_resetCurrentMatchLocalTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 228 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_poseMatchingUtility m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbPoseMatchingGenerator : hkbBlenderGenerator
    {

        public Quaternion m_worldFromModelRotation;
        public float m_blendSpeed;
        public float m_minSpeedToSwitch;
        public float m_minSwitchTimeNoError;
        public float m_minSwitchTimeFullError;
        public int m_startPlayingEventId;
        public int m_startMatchingEventId;
        public short m_rootBoneIndex;
        public short m_otherBoneIndex;
        public short m_anotherBoneIndex;
        public short m_pelvisIndex;
        public sbyte m_mode;
        public int m_currentMatch;
        public int m_bestMatch;
        public float m_timeSinceBetterMatch;
        public float m_error;
        public bool m_resetCurrentMatchLocalTime;
        public dynamic /* POINTER VOID */ m_poseMatchingUtility;

        public override uint Signature => 0x29e271b4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_worldFromModelRotation = des.ReadQuaternion(br);
            m_blendSpeed = br.ReadSingle();
            m_minSpeedToSwitch = br.ReadSingle();
            m_minSwitchTimeNoError = br.ReadSingle();
            m_minSwitchTimeFullError = br.ReadSingle();
            m_startPlayingEventId = br.ReadInt32();
            m_startMatchingEventId = br.ReadInt32();
            m_rootBoneIndex = br.ReadInt16();
            m_otherBoneIndex = br.ReadInt16();
            m_anotherBoneIndex = br.ReadInt16();
            m_pelvisIndex = br.ReadInt16();
            m_mode = br.ReadSByte();
            br.Position += 3;
            m_currentMatch = br.ReadInt32();
            m_bestMatch = br.ReadInt32();
            m_timeSinceBetterMatch = br.ReadSingle();
            m_error = br.ReadSingle();
            m_resetCurrentMatchLocalTime = br.ReadBoolean();
            br.Position += 3;
            des.ReadEmptyPointer(br);/* m_poseMatchingUtility POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternion(bw, m_worldFromModelRotation);
            bw.WriteSingle(m_blendSpeed);
            bw.WriteSingle(m_minSpeedToSwitch);
            bw.WriteSingle(m_minSwitchTimeNoError);
            bw.WriteSingle(m_minSwitchTimeFullError);
            bw.WriteInt32(m_startPlayingEventId);
            bw.WriteInt32(m_startMatchingEventId);
            bw.WriteInt16(m_rootBoneIndex);
            bw.WriteInt16(m_otherBoneIndex);
            bw.WriteInt16(m_anotherBoneIndex);
            bw.WriteInt16(m_pelvisIndex);
            s.WriteSByte(bw, m_mode);
            bw.Position += 3;
            bw.WriteInt32(m_currentMatch);
            bw.WriteInt32(m_bestMatch);
            bw.WriteSingle(m_timeSinceBetterMatch);
            bw.WriteSingle(m_error);
            bw.WriteBoolean(m_resetCurrentMatchLocalTime);
            bw.Position += 3;
            s.WriteVoidPointer(bw);/* m_poseMatchingUtility POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

