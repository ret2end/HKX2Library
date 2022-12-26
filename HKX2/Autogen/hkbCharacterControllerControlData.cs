using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterControllerControlData Signatire: 0x5b6c03d9 size: 32 flags: FLAGS_NONE

    // m_desiredVelocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_verticalGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_horizontalCatchUpGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_maxVerticalSeparation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_maxHorizontalSeparation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    
    public class hkbCharacterControllerControlData : IHavokObject
    {

        public Vector4 m_desiredVelocity;
        public float m_verticalGain;
        public float m_horizontalCatchUpGain;
        public float m_maxVerticalSeparation;
        public float m_maxHorizontalSeparation;

        public uint Signature => 0x5b6c03d9;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_desiredVelocity = br.ReadVector4();
            m_verticalGain = br.ReadSingle();
            m_horizontalCatchUpGain = br.ReadSingle();
            m_maxVerticalSeparation = br.ReadSingle();
            m_maxHorizontalSeparation = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_desiredVelocity);
            bw.WriteSingle(m_verticalGain);
            bw.WriteSingle(m_horizontalCatchUpGain);
            bw.WriteSingle(m_maxVerticalSeparation);
            bw.WriteSingle(m_maxHorizontalSeparation);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

