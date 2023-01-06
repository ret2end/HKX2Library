using System.Xml.Linq;

namespace HKX2
{
    // hkbGetHandleOnBoneModifier Signatire: 0x50c34a17 size: 104 flags: FLAGS_NONE

    // m_handleOut m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_localFrameName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_ragdollBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_animationBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 98 flags: FLAGS_NONE enum: 
    public partial class hkbGetHandleOnBoneModifier : hkbModifier
    {
        public hkbHandle m_handleOut;
        public string m_localFrameName;
        public short m_ragdollBoneIndex;
        public short m_animationBoneIndex;

        public override uint Signature => 0x50c34a17;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_handleOut = des.ReadClassPointer<hkbHandle>(br);
            m_localFrameName = des.ReadStringPointer(br);
            m_ragdollBoneIndex = br.ReadInt16();
            m_animationBoneIndex = br.ReadInt16();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_handleOut);
            s.WriteStringPointer(bw, m_localFrameName);
            bw.WriteInt16(m_ragdollBoneIndex);
            bw.WriteInt16(m_animationBoneIndex);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_handleOut = xd.ReadClassPointer<hkbHandle>(xe, nameof(m_handleOut));
            m_localFrameName = xd.ReadString(xe, nameof(m_localFrameName));
            m_ragdollBoneIndex = xd.ReadInt16(xe, nameof(m_ragdollBoneIndex));
            m_animationBoneIndex = xd.ReadInt16(xe, nameof(m_animationBoneIndex));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_handleOut), m_handleOut);
            xs.WriteString(xe, nameof(m_localFrameName), m_localFrameName);
            xs.WriteNumber(xe, nameof(m_ragdollBoneIndex), m_ragdollBoneIndex);
            xs.WriteNumber(xe, nameof(m_animationBoneIndex), m_animationBoneIndex);
        }
    }
}

