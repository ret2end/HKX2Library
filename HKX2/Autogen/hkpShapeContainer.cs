using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpShapeContainer Signatire: 0xe0708a00 size: 8 flags: FLAGS_NONE


    
    public class hkpShapeContainer : IHavokObject
    {

        public byte[] unk0;

        public virtual uint Signature => 0xe0708a00;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            unk0 = br.ReadBytes(8);

            // throw new NotImplementedException("code generated. check first");
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBytes(unk0);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

