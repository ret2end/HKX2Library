using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkColor Signatire: 0x106b96ce size: 1 flags: FLAGS_NONE


    
    public class hkColor : IHavokObject
    {

        public byte[] unk0;

        public uint Signature => 0x106b96ce;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            unk0 = br.ReadBytes(1);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBytes(unk0);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

