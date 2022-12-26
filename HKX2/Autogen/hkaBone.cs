using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaBone Signatire: 0x35912f8a size: 16 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_lockTranslation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkaBone : IHavokObject
    {

        public string m_name;
        public bool m_lockTranslation;

        public uint Signature => 0x35912f8a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);
            m_lockTranslation = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);
            bw.WriteBoolean(m_lockTranslation);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

