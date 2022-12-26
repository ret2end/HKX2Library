using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintData Signatire: 0x80559a4e size: 24 flags: FLAGS_NONE

    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpConstraintData : hkReferencedObject
    {

        public ulong m_userData;

        public override uint Signature => 0x80559a4e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_userData = br.ReadUInt64();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_userData);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
