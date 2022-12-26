using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpGroupCollisionFilter Signatire: 0x5cc01561 size: 208 flags: FLAGS_NONE

    // m_noGroupCollisionEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_collisionGroups m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 32 offset: 76 flags:  enum: 

    public class hkpGroupCollisionFilter : hkpCollisionFilter
    {

        public bool m_noGroupCollisionEnabled;
        public List<uint> m_collisionGroups;

        public override uint Signature => 0x5cc01561;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_noGroupCollisionEnabled = br.ReadBoolean();
            br.Position += 3;
            m_collisionGroups = des.ReadUInt32CStyleArray(br, 32);//m_collisionGroups = br.ReadUInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_noGroupCollisionEnabled);
            bw.Position += 3;
            s.WriteUInt32CStyleArray(bw, m_collisionGroups);//bw.WriteUInt32(m_collisionGroups);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

