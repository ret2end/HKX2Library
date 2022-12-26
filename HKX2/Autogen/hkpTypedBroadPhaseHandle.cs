using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTypedBroadPhaseHandle Signatire: 0xf4b0f799 size: 12 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_ownerOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 5 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_objectQualityType m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 6 flags:  enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpTypedBroadPhaseHandle : hkpBroadPhaseHandle
    {

        public sbyte m_type;
        public sbyte m_ownerOffset;
        public sbyte m_objectQualityType;
        public uint m_collisionFilterInfo;

        public override uint Signature => 0xf4b0f799;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_type = br.ReadSByte();
            m_ownerOffset = br.ReadSByte();
            m_objectQualityType = br.ReadSByte();
            br.Position += 1;
            m_collisionFilterInfo = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSByte(m_type);
            bw.WriteSByte(m_ownerOffset);
            bw.WriteSByte(m_objectQualityType);
            bw.Position += 1;
            bw.WriteUInt32(m_collisionFilterInfo);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

