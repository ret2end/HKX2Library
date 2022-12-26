using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaAnnotationTrackAnnotation Signatire: 0x623bf34f size: 16 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_text m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkaAnnotationTrackAnnotation : IHavokObject
    {

        public float m_time;
        public string m_text;

        public uint Signature => 0x623bf34f;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_time = br.ReadSingle();
            br.Position += 4;
            m_text = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_time);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_text);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

