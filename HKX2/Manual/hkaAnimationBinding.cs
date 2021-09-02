using System.Collections.Generic;

namespace HKX2
{
    public enum BlendHint
    {
        NORMAL = 0,
        ADDITIVE_DEPRECATED = 1,
        ADDITIVE = 2
    }

    public class hkaAnimationBinding : hkReferencedObject
    {
        public hkaAnimation m_animation;
        public BlendHint m_blendHint;
        public List<short> m_floatTrackToFloatSlotIndices;

        public string m_originalSkeletonName;
        public List<short> m_partitionIndices;
        public List<short> m_transformTrackToBoneIndices;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_originalSkeletonName = des.ReadStringPointer(br);
            m_animation = des.ReadClassPointer<hkaAnimation>(br);
            m_transformTrackToBoneIndices = des.ReadInt16Array(br);
            m_floatTrackToFloatSlotIndices = des.ReadInt16Array(br);
            m_partitionIndices = des.ReadInt16Array(br);
            m_blendHint = (BlendHint) br.ReadSByte();
            br.ReadByte();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_originalSkeletonName);
            s.WriteClassPointer(bw, m_animation);
            s.WriteInt16Array(bw, m_transformTrackToBoneIndices);
            s.WriteInt16Array(bw, m_floatTrackToFloatSlotIndices);
            s.WriteInt16Array(bw, m_partitionIndices);
            bw.WriteSByte((sbyte) m_blendHint);
            bw.WriteByte(0);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}