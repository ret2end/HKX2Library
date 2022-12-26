using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRotateCharacterModifier Signatire: 0x877ebc0b size: 128 flags: FLAGS_NONE

    // m_degreesPerSecond m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_speedMultiplier m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_axisOfRotation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_angle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbRotateCharacterModifier : hkbModifier
    {

        public float m_degreesPerSecond;
        public float m_speedMultiplier;
        public Vector4 m_axisOfRotation;
        public float m_angle;

        public override uint Signature => 0x877ebc0b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_degreesPerSecond = br.ReadSingle();
            m_speedMultiplier = br.ReadSingle();
            br.Position += 8;
            m_axisOfRotation = br.ReadVector4();
            m_angle = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_degreesPerSecond);
            bw.WriteSingle(m_speedMultiplier);
            bw.Position += 8;
            bw.WriteVector4(m_axisOfRotation);
            bw.WriteSingle(m_angle);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

