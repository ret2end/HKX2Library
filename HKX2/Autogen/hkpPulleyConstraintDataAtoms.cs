using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPulleyConstraintDataAtoms Signatire: 0xb149e5a size: 112 flags: FLAGS_NONE

    // m_translations m_class: hkpSetLocalTranslationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_pulley m_class: hkpPulleyConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpPulleyConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTranslationsConstraintAtom/*struct void*/ m_translations;
        public hkpPulleyConstraintAtom/*struct void*/ m_pulley;

        public uint Signature => 0xb149e5a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_translations = new hkpSetLocalTranslationsConstraintAtom();
            m_translations.Read(des,br);
            m_pulley = new hkpPulleyConstraintAtom();
            m_pulley.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_translations.Write(s, bw);
            m_pulley.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

