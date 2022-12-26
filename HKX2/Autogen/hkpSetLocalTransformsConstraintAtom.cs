using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSetLocalTransformsConstraintAtom Signatire: 0x6e2a5198 size: 144 flags: FLAGS_NONE

    // m_transformA m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_transformB m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkpSetLocalTransformsConstraintAtom : hkpConstraintAtom
    {

        public Matrix4x4 m_transformA;
        public Matrix4x4 m_transformB;

        public override uint Signature => 0x6e2a5198;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 14;
            m_transformA = des.ReadTransform(br);
            m_transformB = des.ReadTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 14;
            s.WriteTransform(bw, m_transformA);
            s.WriteTransform(bw, m_transformB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

