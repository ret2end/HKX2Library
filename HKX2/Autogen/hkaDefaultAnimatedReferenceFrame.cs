using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaDefaultAnimatedReferenceFrame Signatire: 0x6d85e445 size: 80 flags: FLAGS_NONE

    // m_up m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_forward m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_referenceFrameSamples m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 56 flags:  enum: 
    
    public class hkaDefaultAnimatedReferenceFrame : hkaAnimatedReferenceFrame
    {

        public Vector4 m_up;
        public Vector4 m_forward;
        public float m_duration;
        public List<Vector4> m_referenceFrameSamples;

        public override uint Signature => 0x6d85e445;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_up = br.ReadVector4();
            m_forward = br.ReadVector4();
            m_duration = br.ReadSingle();
            br.Position += 4;
            m_referenceFrameSamples = des.ReadVector4Array(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_up);
            bw.WriteVector4(m_forward);
            bw.WriteSingle(m_duration);
            bw.Position += 4;
            s.WriteVector4Array(bw, m_referenceFrameSamples);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

