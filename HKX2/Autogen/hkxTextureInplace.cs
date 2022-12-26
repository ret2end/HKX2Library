using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxTextureInplace Signatire: 0xd45841d6 size: 56 flags: FLAGS_NONE

    // m_fileType m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 4 offset: 16 flags:  enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 24 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_originalFilename m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkxTextureInplace : hkReferencedObject
    {

        //public List<string/*char*/> m_fileType;
        public string m_fileType;
        public List<byte> m_data;
        public string m_name;
        public string m_originalFilename;

        public override uint Signature => 0xd45841d6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_fileType = br.ReadASCII(4);
            br.Position += 4;
            m_data = des.ReadByteArray(br);
            m_name = des.ReadStringPointer(br);
            m_originalFilename = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteASCII(m_fileType);
            bw.Position += 4;
            s.WriteByteArray(bw, m_data);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_originalFilename);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

