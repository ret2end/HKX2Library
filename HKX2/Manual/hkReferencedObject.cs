using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkReferencedObject Signatire: 0x3b1c1113 size: 16 flags: FLAGS_NONE

    // m_memSizeAndFlags m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 8 flags: SERIALIZE_IGNORED enum: 
    // m_referenceCount m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 10 flags: SERIALIZE_IGNORED enum: 

    public class hkReferencedObject : hkBaseObject
    {

        public ushort m_memSizeAndFlags;
        public short m_referenceCount;

        public override uint Signature => 0x3b1c1113;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_memSizeAndFlags = br.ReadUInt16();
            m_referenceCount = br.ReadInt16();

            //br.Position += 4;
            if (des._header.PointerSize == 8) br.Pad(8);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt16(m_memSizeAndFlags);
            bw.WriteInt16(m_referenceCount);

            //bw.Position += 4;
            if (s._header.PointerSize == 8) bw.Pad(8);
        }
    }
}

