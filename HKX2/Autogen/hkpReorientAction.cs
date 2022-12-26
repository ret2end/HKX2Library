using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpReorientAction Signatire: 0x2dc0ec6a size: 112 flags: FLAGS_NONE

    // m_rotationAxis m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_upAxis m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    
    public class hkpReorientAction : hkpUnaryAction
    {

        public Vector4 m_rotationAxis;
        public Vector4 m_upAxis;
        public float m_strength;
        public float m_damping;

        public override uint Signature => 0x2dc0ec6a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_rotationAxis = br.ReadVector4();
            m_upAxis = br.ReadVector4();
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_rotationAxis);
            bw.WriteVector4(m_upAxis);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

