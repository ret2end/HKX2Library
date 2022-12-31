using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterSetup Signatire: 0xe5a2a413 size: 88 flags: FLAGS_NONE

    // m_retargetingSkeletonMappers m_class: hkaSkeletonMapper Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_animationSkeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_ragdollToAnimationSkeletonMapper m_class: hkaSkeletonMapper Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_animationToRagdollSkeletonMapper m_class: hkaSkeletonMapper Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_animationBindingSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_data m_class: hkbCharacterData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_mirroredSkeleton m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_characterPropertyIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 80 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbCharacterSetup : hkReferencedObject
    {
        public List<hkaSkeletonMapper> m_retargetingSkeletonMappers;
        public hkaSkeleton m_animationSkeleton;
        public hkaSkeletonMapper m_ragdollToAnimationSkeletonMapper;
        public hkaSkeletonMapper m_animationToRagdollSkeletonMapper;
        public dynamic m_animationBindingSet;
        public hkbCharacterData m_data;
        public dynamic m_mirroredSkeleton;
        public dynamic m_characterPropertyIdMap;

        public override uint Signature => 0xe5a2a413;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_retargetingSkeletonMappers = des.ReadClassPointerArray<hkaSkeletonMapper>(br);
            m_animationSkeleton = des.ReadClassPointer<hkaSkeleton>(br);
            m_ragdollToAnimationSkeletonMapper = des.ReadClassPointer<hkaSkeletonMapper>(br);
            m_animationToRagdollSkeletonMapper = des.ReadClassPointer<hkaSkeletonMapper>(br);
            des.ReadEmptyPointer(br);
            m_data = des.ReadClassPointer<hkbCharacterData>(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkaSkeletonMapper>(bw, m_retargetingSkeletonMappers);
            s.WriteClassPointer(bw, m_animationSkeleton);
            s.WriteClassPointer(bw, m_ragdollToAnimationSkeletonMapper);
            s.WriteClassPointer(bw, m_animationToRagdollSkeletonMapper);
            s.WriteVoidPointer(bw);
            s.WriteClassPointer(bw, m_data);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkaSkeletonMapper>(xe, nameof(m_retargetingSkeletonMappers), m_retargetingSkeletonMappers);
            xs.WriteClassPointer(xe, nameof(m_animationSkeleton), m_animationSkeleton);
            xs.WriteClassPointer(xe, nameof(m_ragdollToAnimationSkeletonMapper), m_ragdollToAnimationSkeletonMapper);
            xs.WriteClassPointer(xe, nameof(m_animationToRagdollSkeletonMapper), m_animationToRagdollSkeletonMapper);
            xs.WriteSerializeIgnored(xe, nameof(m_animationBindingSet));
            xs.WriteClassPointer(xe, nameof(m_data), m_data);
            xs.WriteSerializeIgnored(xe, nameof(m_mirroredSkeleton));
            xs.WriteSerializeIgnored(xe, nameof(m_characterPropertyIdMap));
        }
    }
}

