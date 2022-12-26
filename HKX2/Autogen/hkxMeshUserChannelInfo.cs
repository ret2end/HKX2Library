using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxMeshUserChannelInfo Signatire: 0x270724a5 size: 48 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_className m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkxMeshUserChannelInfo : hkxAttributeHolder
    {

        public string m_name;
        public string m_className;

        public override uint Signature => 0x270724a5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_className = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_className);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

