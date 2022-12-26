using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorEventsInfo Signatire: 0x66840004 size: 48 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_externalEventIds m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 24 flags:  enum: 
    // m_padding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkbBehaviorEventsInfo : hkReferencedObject
    {

        public ulong m_characterId;
        public List<short> m_externalEventIds;
        public int m_padding;

        public override uint Signature => 0x66840004;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_externalEventIds = des.ReadInt16Array(br);
            m_padding = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteInt16Array(bw, m_externalEventIds);
            bw.WriteInt32(m_padding);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
