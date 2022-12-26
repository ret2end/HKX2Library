using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventBase Signatire: 0x76bddb31 size: 16 flags: FLAGS_NONE

    // m_id m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_payload m_class: hkbEventPayload Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkbEventBase : IHavokObject
    {

        public int m_id;
        public hkbEventPayload /*pointer struct*/ m_payload;

        public virtual uint Signature => 0x76bddb31;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_id = br.ReadInt32();
            br.Position += 4;
            m_payload = des.ReadClassPointer<hkbEventPayload>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_id);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_payload);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

