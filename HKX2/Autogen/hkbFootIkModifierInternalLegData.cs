using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkModifierInternalLegData Signatire: 0xe5ca3677 size: 32 flags: FLAGS_NONE

    // m_groundPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_footIkSolver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbFootIkModifierInternalLegData : IHavokObject
    {

        public Vector4 m_groundPosition;
        public dynamic /* POINTER VOID */ m_footIkSolver;

        public uint Signature => 0xe5ca3677;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_groundPosition = br.ReadVector4();
            des.ReadEmptyPointer(br);/* m_footIkSolver POINTER VOID */
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_groundPosition);
            s.WriteVoidPointer(bw);/* m_footIkSolver POINTER VOID */
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

