using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMotorAction Signatire: 0x8ff131d9 size: 96 flags: FLAGS_NONE

    // m_axis m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_spinRate m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_gain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_active m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    
    public class hkpMotorAction : hkpUnaryAction
    {

        public Vector4 m_axis;
        public float m_spinRate;
        public float m_gain;
        public bool m_active;

        public override uint Signature => 0x8ff131d9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_axis = br.ReadVector4();
            m_spinRate = br.ReadSingle();
            m_gain = br.ReadSingle();
            m_active = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_axis);
            bw.WriteSingle(m_spinRate);
            bw.WriteSingle(m_gain);
            bw.WriteBoolean(m_active);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

