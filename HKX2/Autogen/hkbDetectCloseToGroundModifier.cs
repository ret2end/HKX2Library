using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbDetectCloseToGroundModifier Signatire: 0x981687b2 size: 120 flags: FLAGS_NONE

    // m_closeToGroundEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_closeToGroundHeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_raycastDistanceDown m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_boneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_animBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 110 flags:  enum: 
    // m_isCloseToGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbDetectCloseToGroundModifier : hkbModifier
    {

        public hkbEventProperty/*struct void*/ m_closeToGroundEvent;
        public float m_closeToGroundHeight;
        public float m_raycastDistanceDown;
        public uint m_collisionFilterInfo;
        public short m_boneIndex;
        public short m_animBoneIndex;
        public bool m_isCloseToGround;

        public override uint Signature => 0x981687b2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_closeToGroundEvent = new hkbEventProperty();
            m_closeToGroundEvent.Read(des,br);
            m_closeToGroundHeight = br.ReadSingle();
            m_raycastDistanceDown = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            m_boneIndex = br.ReadInt16();
            m_animBoneIndex = br.ReadInt16();
            m_isCloseToGround = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_closeToGroundEvent.Write(s, bw);
            bw.WriteSingle(m_closeToGroundHeight);
            bw.WriteSingle(m_raycastDistanceDown);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.WriteInt16(m_boneIndex);
            bw.WriteInt16(m_animBoneIndex);
            bw.WriteBoolean(m_isCloseToGround);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

