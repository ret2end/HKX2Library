using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPhantom Signatire: 0x9b7e6f86 size: 240 flags: FLAGS_NONE

    // m_overlapListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_phantomListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpPhantom : hkpWorldObject
    {

        //public List<> m_overlapListeners;
        //public List<> m_phantomListeners;

        public override uint Signature => 0x9b7e6f86;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyArray(br); //m_overlapListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br); //m_phantomListeners = des.ReadClassPointerArray<>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidArray(bw); //s.WriteClassPointerArray<>(bw, m_overlapListeners);
            s.WriteVoidArray(bw); //s.WriteClassPointerArray<>(bw, m_phantomListeners);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

