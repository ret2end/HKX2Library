using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRaiseEventCommand Signatire: 0xa0a7bf9c size: 32 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_global m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_externalId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    
    public class hkbRaiseEventCommand : hkReferencedObject
    {

        public ulong m_characterId;
        public bool m_global;
        public int m_externalId;

        public override uint Signature => 0xa0a7bf9c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_global = br.ReadBoolean();
            br.Position += 3;
            m_externalId = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            bw.WriteBoolean(m_global);
            bw.Position += 3;
            bw.WriteInt32(m_externalId);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
