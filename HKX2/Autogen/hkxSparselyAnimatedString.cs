using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxSparselyAnimatedString Signatire: 0x185da6fd size: 48 flags: FLAGS_NONE

    // m_strings m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags:  enum: 
    // m_times m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkxSparselyAnimatedString : hkReferencedObject
    {

        public List<string> m_strings;
        public List<float> m_times;

        public override uint Signature => 0x185da6fd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_strings = des.ReadStringPointerArray(br);
            m_times = des.ReadSingleArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_strings);
            s.WriteSingleArray(bw, m_times);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

