using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxSparselyAnimatedEnum Signatire: 0x68a47b64 size: 56 flags: FLAGS_NONE

    // m_enum m_class: hkxEnum Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkxSparselyAnimatedEnum : hkxSparselyAnimatedInt
    {

        public hkxEnum /*pointer struct*/ m_enum;

        public override uint Signature => 0x68a47b64;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_enum = des.ReadClassPointer<hkxEnum>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_enum);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

