using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBvTreeShape Signatire: 0xa823d623 size: 40 flags: FLAGS_NONE

    // m_bvTreeType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: BvTreeType
    
    public class hkpBvTreeShape : hkpShape
    {

        public byte m_bvTreeType;

        public override uint Signature => 0xa823d623;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_bvTreeType = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_bvTreeType);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

