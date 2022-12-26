using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpWeldingUtility Signatire: 0xb2b41feb size: 1 flags: FLAGS_NONE


    
    public class hkpWeldingUtility : IHavokObject
    {

        public byte[] unk0;

        public uint Signature => 0xb2b41feb;

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

