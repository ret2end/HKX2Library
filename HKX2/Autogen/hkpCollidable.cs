using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCollidable Signatire: 0x9a0e42a5 size: 112 flags: FLAGS_NONE

    // m_ownerOffset m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 32 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_forceCollideOntoPpu m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 33 flags:  enum: 
    // m_shapeSizeOnSpu m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 34 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_broadPhaseHandle m_class: hkpTypedBroadPhaseHandle Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_boundingVolumeData m_class: hkpCollidableBoundingVolumeData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_allowedPenetrationDepth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    
    public class hkpCollidable : hkpCdBody
    {

        public sbyte m_ownerOffset;
        public byte m_forceCollideOntoPpu;
        public ushort m_shapeSizeOnSpu;
        public hkpTypedBroadPhaseHandle/*struct void*/ m_broadPhaseHandle;
        public hkpCollidableBoundingVolumeData/*struct void*/ m_boundingVolumeData;
        public float m_allowedPenetrationDepth;

        public override uint Signature => 0x9a0e42a5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_ownerOffset = br.ReadSByte();
            m_forceCollideOntoPpu = br.ReadByte();
            m_shapeSizeOnSpu = br.ReadUInt16();
            m_broadPhaseHandle = new hkpTypedBroadPhaseHandle();
            m_broadPhaseHandle.Read(des,br);
            m_boundingVolumeData = new hkpCollidableBoundingVolumeData();
            m_boundingVolumeData.Read(des,br);
            m_allowedPenetrationDepth = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSByte(m_ownerOffset);
            bw.WriteByte(m_forceCollideOntoPpu);
            bw.WriteUInt16(m_shapeSizeOnSpu);
            m_broadPhaseHandle.Write(s, bw);
            m_boundingVolumeData.Write(s, bw);
            bw.WriteSingle(m_allowedPenetrationDepth);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

