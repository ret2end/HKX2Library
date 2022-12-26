using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpNamedMeshMaterial Signatire: 0x66b42df1 size: 16 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpNamedMeshMaterial : hkpMeshMaterial
    {

        public string m_name;

        public override uint Signature => 0x66b42df1;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 4;
            m_name = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

