using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpStiffSpringConstraintDataAtoms Signatire: 0x207eb376 size: 64 flags: FLAGS_NONE

    // m_pivots m_class: hkpSetLocalTranslationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_spring m_class: hkpStiffSpringConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpStiffSpringConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTranslationsConstraintAtom/*struct void*/ m_pivots;
        public hkpStiffSpringConstraintAtom/*struct void*/ m_spring;

        public uint Signature => 0x207eb376;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pivots = new hkpSetLocalTranslationsConstraintAtom();
            m_pivots.Read(des,br);
            m_spring = new hkpStiffSpringConstraintAtom();
            m_spring.Read(des,br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_pivots.Write(s, bw);
            m_spring.Write(s, bw);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

