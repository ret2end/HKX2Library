using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPairCollisionFilterMapPairFilterKeyOverrideType Signatire: 0x36195969 size: 16 flags: FLAGS_NONE

    // m_elem m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_numElems m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_hashMod m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkpPairCollisionFilterMapPairFilterKeyOverrideType : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_elem;
        public int m_numElems;
        public int m_hashMod;

        public uint Signature => 0x36195969;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_elem POINTER VOID */
            m_numElems = br.ReadInt32();
            m_hashMod = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_elem POINTER VOID */
            bw.WriteInt32(m_numElems);
            bw.WriteInt32(m_hashMod);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

