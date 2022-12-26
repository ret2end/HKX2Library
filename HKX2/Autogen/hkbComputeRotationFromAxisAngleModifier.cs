using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbComputeRotationFromAxisAngleModifier Signatire: 0x9b3f6936 size: 128 flags: FLAGS_NONE

    // m_rotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_axis m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_angleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    
    public class hkbComputeRotationFromAxisAngleModifier : hkbModifier
    {

        public Quaternion m_rotationOut;
        public Vector4 m_axis;
        public float m_angleDegrees;

        public override uint Signature => 0x9b3f6936;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rotationOut = des.ReadQuaternion(br);
            m_axis = br.ReadVector4();
            m_angleDegrees = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotationOut);
            bw.WriteVector4(m_axis);
            bw.WriteSingle(m_angleDegrees);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

