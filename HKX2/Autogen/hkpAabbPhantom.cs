using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAabbPhantom Signatire: 0x2c5189dd size: 304 flags: FLAGS_NONE

    // m_aabb m_class: hkAabb Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 240 flags:  enum: 
    // m_overlappingCollidables m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 272 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_orderDirty m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 288 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpAabbPhantom : hkpPhantom
    {

        public hkAabb/*struct void*/ m_aabb;
        //public List<> m_overlappingCollidables;
        public bool m_orderDirty;

        public override uint Signature => 0x2c5189dd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_aabb = new hkAabb();
            m_aabb.Read(des,br);
            des.ReadEmptyArray(br); //m_overlappingCollidables = des.ReadClassPointerArray<>(br);
            m_orderDirty = br.ReadBoolean();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_aabb.Write(s, bw);
            s.WriteVoidArray(bw); //s.WriteClassPointerArray<>(bw, m_overlappingCollidables);
            bw.WriteBoolean(m_orderDirty);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

