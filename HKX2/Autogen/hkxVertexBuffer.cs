using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexBuffer Signatire: 0x4ab10615 size: 136 flags: FLAGS_NONE

    // m_data m_class: hkxVertexBufferVertexData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_desc m_class: hkxVertexDescription Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    
    public class hkxVertexBuffer : hkReferencedObject
    {

        public hkxVertexBufferVertexData/*struct void*/ m_data;
        public hkxVertexDescription/*struct void*/ m_desc;

        public override uint Signature => 0x4ab10615;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_data = new hkxVertexBufferVertexData();
            m_data.Read(des,br);
            m_desc = new hkxVertexDescription();
            m_desc.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_data.Write(s, bw);
            m_desc.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

