using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMouseSpringAction Signatire: 0x6e087fd6 size: 144 flags: FLAGS_NONE

    // m_positionInRbLocal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_mousePositionInWorld m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_springDamping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_springElasticity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_maxRelativeForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_objectDamping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_shapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_applyCallbacks m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpMouseSpringAction : hkpUnaryAction
    {

        public Vector4 m_positionInRbLocal;
        public Vector4 m_mousePositionInWorld;
        public float m_springDamping;
        public float m_springElasticity;
        public float m_maxRelativeForce;
        public float m_objectDamping;
        public uint m_shapeKey;
        //public List<> m_applyCallbacks;

        public override uint Signature => 0x6e087fd6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_positionInRbLocal = br.ReadVector4();
            m_mousePositionInWorld = br.ReadVector4();
            m_springDamping = br.ReadSingle();
            m_springElasticity = br.ReadSingle();
            m_maxRelativeForce = br.ReadSingle();
            m_objectDamping = br.ReadSingle();
            m_shapeKey = br.ReadUInt32();
            br.Position += 4;
            des.ReadEmptyArray(br); //m_applyCallbacks = des.ReadClassPointerArray<>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_positionInRbLocal);
            bw.WriteVector4(m_mousePositionInWorld);
            bw.WriteSingle(m_springDamping);
            bw.WriteSingle(m_springElasticity);
            bw.WriteSingle(m_maxRelativeForce);
            bw.WriteSingle(m_objectDamping);
            bw.WriteUInt32(m_shapeKey);
            bw.Position += 4;
            s.WriteVoidArray(bw); //s.WriteClassPointerArray<>(bw, m_applyCallbacks);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

