using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLinkedCollidable Signatire: 0xe1a81497 size: 128 flags: FLAGS_NONE

    // m_collisionEntries m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpLinkedCollidable : hkpCollidable
    {

        public List<ulong> m_collisionEntries;

        public override uint Signature => 0xe1a81497;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyArray(br); //m_collisionEntries

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidArray(bw); // m_collisionEntries

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

