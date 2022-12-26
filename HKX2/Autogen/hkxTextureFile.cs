using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxTextureFile Signatire: 0x1e289259 size: 40 flags: FLAGS_NONE

    // m_filename m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_originalFilename m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkxTextureFile : hkReferencedObject
    {

        public string m_filename;
        public string m_name;
        public string m_originalFilename;

        public override uint Signature => 0x1e289259;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_filename = des.ReadStringPointer(br);
            m_name = des.ReadStringPointer(br);
            m_originalFilename = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_filename);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_originalFilename);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

