using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxNodeAnnotationData Signatire: 0x433dee92 size: 16 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_description m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkxNodeAnnotationData : IHavokObject
    {

        public float m_time;
        public string m_description;

        public uint Signature => 0x433dee92;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_time = br.ReadSingle();
            br.Position += 4;
            m_description = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_time);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_description);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

