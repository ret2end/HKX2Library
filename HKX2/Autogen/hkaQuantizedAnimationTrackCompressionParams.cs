using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaQuantizedAnimationTrackCompressionParams Signatire: 0xf7d64649 size: 16 flags: FLAGS_NONE

    // m_rotationTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_translationTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_scaleTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_floatingTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkaQuantizedAnimationTrackCompressionParams : IHavokObject
    {

        public float m_rotationTolerance;
        public float m_translationTolerance;
        public float m_scaleTolerance;
        public float m_floatingTolerance;

        public uint Signature => 0xf7d64649;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rotationTolerance = br.ReadSingle();
            m_translationTolerance = br.ReadSingle();
            m_scaleTolerance = br.ReadSingle();
            m_floatingTolerance = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_rotationTolerance);
            bw.WriteSingle(m_translationTolerance);
            bw.WriteSingle(m_scaleTolerance);
            bw.WriteSingle(m_floatingTolerance);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

