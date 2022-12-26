using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSplineCompressedAnimationTrackCompressionParams Signatire: 0x42e878d3 size: 28 flags: FLAGS_NONE

    // m_rotationTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_translationTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_scaleTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_floatingTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_rotationDegree m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_translationDegree m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 18 flags:  enum: 
    // m_scaleDegree m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_floatingDegree m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 22 flags:  enum: 
    // m_rotationQuantizationType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags:  enum: RotationQuantization
    // m_translationQuantizationType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 25 flags:  enum: ScalarQuantization
    // m_scaleQuantizationType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 26 flags:  enum: ScalarQuantization
    // m_floatQuantizationType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 27 flags:  enum: ScalarQuantization
    
    public class hkaSplineCompressedAnimationTrackCompressionParams : IHavokObject
    {

        public float m_rotationTolerance;
        public float m_translationTolerance;
        public float m_scaleTolerance;
        public float m_floatingTolerance;
        public ushort m_rotationDegree;
        public ushort m_translationDegree;
        public ushort m_scaleDegree;
        public ushort m_floatingDegree;
        public byte m_rotationQuantizationType;
        public byte m_translationQuantizationType;
        public byte m_scaleQuantizationType;
        public byte m_floatQuantizationType;

        public uint Signature => 0x42e878d3;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rotationTolerance = br.ReadSingle();
            m_translationTolerance = br.ReadSingle();
            m_scaleTolerance = br.ReadSingle();
            m_floatingTolerance = br.ReadSingle();
            m_rotationDegree = br.ReadUInt16();
            m_translationDegree = br.ReadUInt16();
            m_scaleDegree = br.ReadUInt16();
            m_floatingDegree = br.ReadUInt16();
            m_rotationQuantizationType = br.ReadByte();
            m_translationQuantizationType = br.ReadByte();
            m_scaleQuantizationType = br.ReadByte();
            m_floatQuantizationType = br.ReadByte();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_rotationTolerance);
            bw.WriteSingle(m_translationTolerance);
            bw.WriteSingle(m_scaleTolerance);
            bw.WriteSingle(m_floatingTolerance);
            bw.WriteUInt16(m_rotationDegree);
            bw.WriteUInt16(m_translationDegree);
            bw.WriteUInt16(m_scaleDegree);
            bw.WriteUInt16(m_floatingDegree);
            s.WriteByte(bw, m_rotationQuantizationType);
            s.WriteByte(bw, m_translationQuantizationType);
            s.WriteByte(bw, m_scaleQuantizationType);
            s.WriteByte(bw, m_floatQuantizationType);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

