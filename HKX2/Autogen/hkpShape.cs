using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpShape Signatire: 0x666490a1 size: 32 flags: FLAGS_NONE

    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT32 arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpShape : hkReferencedObject
    {

        public ulong m_userData;
        public uint m_type;

        public override uint Signature => 0x666490a1;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_userData = br.ReadUInt64();
            m_type = br.ReadUInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_userData);
            s.WriteUInt32(bw, m_type);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

