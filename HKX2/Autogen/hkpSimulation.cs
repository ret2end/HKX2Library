using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSimulation Signatire: 0x97aba922 size: 64 flags: FLAGS_NOT_SERIALIZABLE

    // m_determinismCheckFrameCounter m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_world m_class: hkpWorld Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_lastProcessingStep m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: LastProcessingStep
    // m_currentTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_currentPsiTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_physicsDeltaTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    // m_simulateUntilTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_frameMarkerPsiSnap m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    // m_previousStepResult m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    
    public class hkpSimulation : hkReferencedObject
    {

        public uint m_determinismCheckFrameCounter;
        public hkpWorld /*pointer struct*/ m_world;
        public byte m_lastProcessingStep;
        public float m_currentTime;
        public float m_currentPsiTime;
        public float m_physicsDeltaTime;
        public float m_simulateUntilTime;
        public float m_frameMarkerPsiSnap;
        public uint m_previousStepResult;

        public override uint Signature => 0x97aba922;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_determinismCheckFrameCounter = br.ReadUInt32();
            br.Position += 4;
            m_world = des.ReadClassPointer<hkpWorld>(br);
            m_lastProcessingStep = br.ReadByte();
            br.Position += 3;
            m_currentTime = br.ReadSingle();
            m_currentPsiTime = br.ReadSingle();
            m_physicsDeltaTime = br.ReadSingle();
            m_simulateUntilTime = br.ReadSingle();
            m_frameMarkerPsiSnap = br.ReadSingle();
            m_previousStepResult = br.ReadUInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt32(m_determinismCheckFrameCounter);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_world);
            s.WriteByte(bw, m_lastProcessingStep);
            bw.Position += 3;
            bw.WriteSingle(m_currentTime);
            bw.WriteSingle(m_currentPsiTime);
            bw.WriteSingle(m_physicsDeltaTime);
            bw.WriteSingle(m_simulateUntilTime);
            bw.WriteSingle(m_frameMarkerPsiSnap);
            bw.WriteUInt32(m_previousStepResult);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

