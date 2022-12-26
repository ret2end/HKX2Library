using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbGetUpModifier Signatire: 0x61cb7ac0 size: 128 flags: FLAGS_NONE

    // m_groundNormal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_alignWithGroundDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_rootBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_otherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 106 flags:  enum: 
    // m_anotherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_timeSinceBegin m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_initNextModify m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbGetUpModifier : hkbModifier
    {

        public Vector4 m_groundNormal;
        public float m_duration;
        public float m_alignWithGroundDuration;
        public short m_rootBoneIndex;
        public short m_otherBoneIndex;
        public short m_anotherBoneIndex;
        public float m_timeSinceBegin;
        public float m_timeStep;
        public bool m_initNextModify;

        public override uint Signature => 0x61cb7ac0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_groundNormal = br.ReadVector4();
            m_duration = br.ReadSingle();
            m_alignWithGroundDuration = br.ReadSingle();
            m_rootBoneIndex = br.ReadInt16();
            m_otherBoneIndex = br.ReadInt16();
            m_anotherBoneIndex = br.ReadInt16();
            br.Position += 2;
            m_timeSinceBegin = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            m_initNextModify = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_groundNormal);
            bw.WriteSingle(m_duration);
            bw.WriteSingle(m_alignWithGroundDuration);
            bw.WriteInt16(m_rootBoneIndex);
            bw.WriteInt16(m_otherBoneIndex);
            bw.WriteInt16(m_anotherBoneIndex);
            bw.Position += 2;
            bw.WriteSingle(m_timeSinceBegin);
            bw.WriteSingle(m_timeStep);
            bw.WriteBoolean(m_initNextModify);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

