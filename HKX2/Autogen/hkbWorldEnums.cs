using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbWorldEnums Signatire: 0x25640b46 size: 1 flags: FLAGS_NONE


    
    public class hkbWorldEnums : IHavokObject
    {

        public byte[] unk0;

        public uint Signature => 0x25640b46;

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

