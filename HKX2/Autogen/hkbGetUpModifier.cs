using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbGetUpModifier Signatire: 0x61cb7ac0 size: 128 flags: FLAGS_NONE

    // m_groundNormal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_alignWithGroundDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_rootBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_otherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 106 flags: FLAGS_NONE enum: 
    // m_anotherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    // m_timeSinceBegin m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_initNextModify m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbGetUpModifier : hkbModifier
    {
        public Vector4 m_groundNormal { set; get; } = default;
        public float m_duration { set; get; } = default;
        public float m_alignWithGroundDuration { set; get; } = default;
        public short m_rootBoneIndex { set; get; } = default;
        public short m_otherBoneIndex { set; get; } = default;
        public short m_anotherBoneIndex { set; get; } = default;
        private float m_timeSinceBegin { set; get; } = default;
        private float m_timeStep { set; get; } = default;
        private bool m_initNextModify { set; get; } = default;

        public override uint Signature => 0x61cb7ac0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_groundNormal = br.ReadVector4();
            m_duration = br.ReadSingle();
            m_alignWithGroundDuration = br.ReadSingle();
            m_rootBoneIndex = br.ReadInt16();
            m_otherBoneIndex = br.ReadInt16();
            m_anotherBoneIndex = br.ReadInt16();
            br.Position += 2;
            m_timeSinceBegin = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            m_initNextModify = br.ReadBoolean();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_groundNormal);
            bw.WriteSingle(m_duration);
            bw.WriteSingle(m_alignWithGroundDuration);
            bw.WriteInt16(m_rootBoneIndex);
            bw.WriteInt16(m_otherBoneIndex);
            bw.WriteInt16(m_anotherBoneIndex);
            bw.Position += 2;
            bw.WriteSingle(m_timeSinceBegin);
            bw.WriteSingle(m_timeStep);
            bw.WriteBoolean(m_initNextModify);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_groundNormal = xd.ReadVector4(xe, nameof(m_groundNormal));
            m_duration = xd.ReadSingle(xe, nameof(m_duration));
            m_alignWithGroundDuration = xd.ReadSingle(xe, nameof(m_alignWithGroundDuration));
            m_rootBoneIndex = xd.ReadInt16(xe, nameof(m_rootBoneIndex));
            m_otherBoneIndex = xd.ReadInt16(xe, nameof(m_otherBoneIndex));
            m_anotherBoneIndex = xd.ReadInt16(xe, nameof(m_anotherBoneIndex));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_groundNormal), m_groundNormal);
            xs.WriteFloat(xe, nameof(m_duration), m_duration);
            xs.WriteFloat(xe, nameof(m_alignWithGroundDuration), m_alignWithGroundDuration);
            xs.WriteNumber(xe, nameof(m_rootBoneIndex), m_rootBoneIndex);
            xs.WriteNumber(xe, nameof(m_otherBoneIndex), m_otherBoneIndex);
            xs.WriteNumber(xe, nameof(m_anotherBoneIndex), m_anotherBoneIndex);
            xs.WriteSerializeIgnored(xe, nameof(m_timeSinceBegin));
            xs.WriteSerializeIgnored(xe, nameof(m_timeStep));
            xs.WriteSerializeIgnored(xe, nameof(m_initNextModify));
        }
    }
}

