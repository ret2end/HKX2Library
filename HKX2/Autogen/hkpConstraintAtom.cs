using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintAtom Signatire: 0x59d67ef6 size: 2 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT16 arrSize: 0 offset: 0 flags:  enum: AtomType
    
    public class hkpConstraintAtom : IHavokObject
    {

        public ushort m_type;

        public virtual uint Signature => 0x59d67ef6;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_type = br.ReadUInt16();

            // throw new NotImplementedException("code generated. check first");
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteUInt16(bw, m_type);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

