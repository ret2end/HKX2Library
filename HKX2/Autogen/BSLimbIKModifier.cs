using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSLimbIKModifier Signatire: 0x8ea971e5 size: 120 flags: FLAGS_NONE

    // m_limitAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_currentAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_startBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_endBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 90 flags:  enum: 
    // m_gain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_boneRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_castOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pSkeletonMemory m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSLimbIKModifier : hkbModifier
    {

        public float m_limitAngleDegrees;
        public float m_currentAngle;
        public short m_startBoneIndex;
        public short m_endBoneIndex;
        public float m_gain;
        public float m_boneRadius;
        public float m_castOffset;
        public float m_timeStep;
        public dynamic /* POINTER VOID */ m_pSkeletonMemory;

        public override uint Signature => 0x8ea971e5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_limitAngleDegrees = br.ReadSingle();
            m_currentAngle = br.ReadSingle();
            m_startBoneIndex = br.ReadInt16();
            m_endBoneIndex = br.ReadInt16();
            m_gain = br.ReadSingle();
            m_boneRadius = br.ReadSingle();
            m_castOffset = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_pSkeletonMemory POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_limitAngleDegrees);
            bw.WriteSingle(m_currentAngle);
            bw.WriteInt16(m_startBoneIndex);
            bw.WriteInt16(m_endBoneIndex);
            bw.WriteSingle(m_gain);
            bw.WriteSingle(m_boneRadius);
            bw.WriteSingle(m_castOffset);
            bw.WriteSingle(m_timeStep);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_pSkeletonMemory POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

