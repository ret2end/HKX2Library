using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPhysicsSystemWithContacts Signatire: 0xd0fd4bbe size: 120 flags: FLAGS_NONE

    // m_contacts m_class: hkpSerializedAgentNnEntry Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 104 flags:  enum: 
    
    public class hkpPhysicsSystemWithContacts : hkpPhysicsSystem
    {

        public List<hkpSerializedAgentNnEntry> m_contacts;

        public override uint Signature => 0xd0fd4bbe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_contacts = des.ReadClassPointerArray<hkpSerializedAgentNnEntry>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpSerializedAgentNnEntry>(bw, m_contacts);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

