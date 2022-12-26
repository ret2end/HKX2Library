using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkDocumentationAttribute Signatire: 0x630edd9e size: 8 flags: FLAGS_NONE

    // m_docsSectionTag m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkDocumentationAttribute : IHavokObject
    {

        public string m_docsSectionTag;

        public uint Signature => 0x630edd9e;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_docsSectionTag = des.ReadStringPointer(br);//m_docsSectionTag = br.ReadASCII();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_docsSectionTag);//bw.WriteASCII(m_docsSectionTag, true);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

