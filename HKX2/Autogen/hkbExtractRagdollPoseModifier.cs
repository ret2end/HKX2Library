using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbExtractRagdollPoseModifier Signatire: 0x804dcbab size: 88 flags: FLAGS_NONE

    // m_poseMatchingBone0 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_poseMatchingBone1 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 82 flags: FLAGS_NONE enum: 
    // m_poseMatchingBone2 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_enableComputeWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 86 flags: FLAGS_NONE enum: 
    public partial class hkbExtractRagdollPoseModifier : hkbModifier
    {
        public short m_poseMatchingBone0 { set; get; } = default;
        public short m_poseMatchingBone1 { set; get; } = default;
        public short m_poseMatchingBone2 { set; get; } = default;
        public bool m_enableComputeWorldFromModel { set; get; } = default;

        public override uint Signature => 0x804dcbab;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_poseMatchingBone0 = br.ReadInt16();
            m_poseMatchingBone1 = br.ReadInt16();
            m_poseMatchingBone2 = br.ReadInt16();
            m_enableComputeWorldFromModel = br.ReadBoolean();
            br.Position += 1;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt16(m_poseMatchingBone0);
            bw.WriteInt16(m_poseMatchingBone1);
            bw.WriteInt16(m_poseMatchingBone2);
            bw.WriteBoolean(m_enableComputeWorldFromModel);
            bw.Position += 1;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_poseMatchingBone0 = xd.ReadInt16(xe, nameof(m_poseMatchingBone0));
            m_poseMatchingBone1 = xd.ReadInt16(xe, nameof(m_poseMatchingBone1));
            m_poseMatchingBone2 = xd.ReadInt16(xe, nameof(m_poseMatchingBone2));
            m_enableComputeWorldFromModel = xd.ReadBoolean(xe, nameof(m_enableComputeWorldFromModel));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_poseMatchingBone0), m_poseMatchingBone0);
            xs.WriteNumber(xe, nameof(m_poseMatchingBone1), m_poseMatchingBone1);
            xs.WriteNumber(xe, nameof(m_poseMatchingBone2), m_poseMatchingBone2);
            xs.WriteBoolean(xe, nameof(m_enableComputeWorldFromModel), m_enableComputeWorldFromModel);
        }
    }
}

