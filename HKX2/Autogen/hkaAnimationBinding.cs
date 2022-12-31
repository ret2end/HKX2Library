using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaAnimationBinding Signatire: 0x66eac971 size: 72 flags: FLAGS_NONE

    // m_originalSkeletonName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_animation m_class: hkaAnimation Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_transformTrackToBoneIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_floatTrackToFloatSlotIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_blendHint m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 64 flags: FLAGS_NONE enum: BlendHint
    public partial class hkaAnimationBinding : hkReferencedObject
    {
        public string m_originalSkeletonName;
        public hkaAnimation m_animation;
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_originalSkeletonName), m_originalSkeletonName);
            xs.WriteClassPointer(xe, nameof(m_animation), m_animation);
            xs.WriteNumberArray(xe, nameof(m_transformTrackToBoneIndices), m_transformTrackToBoneIndices);
            xs.WriteNumberArray(xe, nameof(m_floatTrackToFloatSlotIndices), m_floatTrackToFloatSlotIndices);
            xs.WriteEnum<BlendHint, sbyte>(xe, nameof(m_blendHint), m_blendHint);
        }
    }
}

