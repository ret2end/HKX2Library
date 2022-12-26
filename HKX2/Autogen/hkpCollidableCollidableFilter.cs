using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCollidableCollidableFilter Signatire: 0xe0708a00 size: 8 flags: FLAGS_NONE


    
    public class hkpCollidableCollidableFilter : IHavokObject
    {

        public byte[] unk0;

        public uint Signature => 0xe0708a00;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            unk0 = br.ReadBytes(8);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBytes(unk0);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

