using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSpringAction Signatire: 0x88fc09fa size: 128 flags: FLAGS_NONE

    // m_lastForce m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_positionAinA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_positionBinB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_restLength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_onCompression m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 124 flags:  enum: 
    // m_onExtension m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 125 flags:  enum: 
    
    public class hkpSpringAction : hkpBinaryAction
    {

        public Vector4 m_lastForce;
        public Vector4 m_positionAinA;
        public Vector4 m_positionBinB;
        public float m_restLength;
        public float m_strength;
        public float m_damping;
        public bool m_onCompression;
        public bool m_onExtension;

        public override uint Signature => 0x88fc09fa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_lastForce = br.ReadVector4();
            m_positionAinA = br.ReadVector4();
            m_positionBinB = br.ReadVector4();
            m_restLength = br.ReadSingle();
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_onCompression = br.ReadBoolean();
            m_onExtension = br.ReadBoolean();
            br.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_lastForce);
            bw.WriteVector4(m_positionAinA);
            bw.WriteVector4(m_positionBinB);
            bw.WriteSingle(m_restLength);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.WriteBoolean(m_onCompression);
            bw.WriteBoolean(m_onExtension);
            bw.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

