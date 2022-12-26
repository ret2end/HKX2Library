using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexDescription Signatire: 0x2df6313d size: 16 flags: FLAGS_NONE

    // m_decls m_class: hkxVertexDescriptionElementDecl Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkxVertexDescription : IHavokObject
    {

        public List<hkxVertexDescriptionElementDecl> m_decls;

        public uint Signature => 0x2df6313d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_decls = des.ReadClassArray<hkxVertexDescriptionElementDecl>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassArray<hkxVertexDescriptionElementDecl>(bw, m_decls);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

