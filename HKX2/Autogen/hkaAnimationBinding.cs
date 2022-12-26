using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaAnimationBinding Signatire: 0x66eac971 size: 72 flags: FLAGS_NONE

    // m_originalSkeletonName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_animation m_class: hkaAnimation Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_transformTrackToBoneIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 32 flags:  enum: 
    // m_floatTrackToFloatSlotIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_blendHint m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 64 flags:  enum: BlendHint
    
    public class hkaAnimationBinding : hkReferencedObject
    {

        public string m_originalSkeletonName;
        public hkaAnimation /*pointer struct*/ m_animation;
        public List<short> m_transformTrackToBoneIndices;
        public List<short> m_floatTrackToFloatSlotIndices;
        public sbyte m_blendHint;

        public override uint Signature => 0x66eac971;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_originalSkeletonName = des.ReadStringPointer(br);
            m_animation = des.ReadClassPointer<hkaAnimation>(br);
            m_transformTrackToBoneIndices = des.ReadInt16Array(br);
            m_floatTrackToFloatSlotIndices = des.ReadInt16Array(br);
            m_blendHint = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_originalSkeletonName);
            s.WriteClassPointer(bw, m_animation);
            s.WriteInt16Array(bw, m_transformTrackToBoneIndices);
            s.WriteInt16Array(bw, m_floatTrackToFloatSlotIndices);
            s.WriteSByte(bw, m_blendHint);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

