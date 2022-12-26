using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpGroupFilter Signatire: 0x65ee88e4 size: 272 flags: FLAGS_NONE

    // m_nextFreeSystemGroup m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_collisionLookupTable m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 32 offset: 76 flags:  enum: 
    // m_pad256 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 4 offset: 208 flags:  enum: 

    public class hkpGroupFilter : hkpCollisionFilter
    {

        public int m_nextFreeSystemGroup;
        public List<uint> m_collisionLookupTable;
        public List<Vector4> m_pad256;

        public override uint Signature => 0x65ee88e4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_nextFreeSystemGroup = br.ReadInt32();
            m_collisionLookupTable = des.ReadUInt32CStyleArray(br, 32);//m_collisionLookupTable = br.ReadUInt32();
            br.Position += 4;
            m_pad256 = des.ReadVector4CStyleArray(br, 4);//m_pad256 = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_nextFreeSystemGroup);
            s.WriteUInt32CStyleArray(bw, m_collisionLookupTable);//bw.WriteUInt32(m_collisionLookupTable);
            bw.Position += 4;
            s.WriteVector4CStyleArray(bw, m_pad256);//bw.WriteVector4(m_pad256);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

