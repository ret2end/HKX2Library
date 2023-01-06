using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkaSkeletonMapperData Signatire: 0x95687ea0 size: 128 flags: FLAGS_NONE

    // m_skeletonA m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_skeletonB m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_simpleMappings m_class: hkaSkeletonMapperDataSimpleMapping Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_chainMappings m_class: hkaSkeletonMapperDataChainMapping Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_unmappedBones m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_extractedMotionMapping m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_keepUnmappedLocal m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_mappingType m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 116 flags: FLAGS_NONE enum: MappingType
    public partial class hkaSkeletonMapperData : IHavokObject
    {
        public hkaSkeleton m_skeletonA;
        public hkaSkeleton m_skeletonB;
        public List<hkaSkeletonMapperDataSimpleMapping> m_simpleMappings = new List<hkaSkeletonMapperDataSimpleMapping>();
        public List<hkaSkeletonMapperDataChainMapping> m_chainMappings = new List<hkaSkeletonMapperDataChainMapping>();
        public List<short> m_unmappedBones;
        public Matrix4x4 m_extractedMotionMapping;
        public bool m_keepUnmappedLocal;
        public int m_mappingType;

        public virtual uint Signature => 0x95687ea0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_skeletonA = des.ReadClassPointer<hkaSkeleton>(br);
            m_skeletonB = des.ReadClassPointer<hkaSkeleton>(br);
            m_simpleMappings = des.ReadClassArray<hkaSkeletonMapperDataSimpleMapping>(br);
            m_chainMappings = des.ReadClassArray<hkaSkeletonMapperDataChainMapping>(br);
            m_unmappedBones = des.ReadInt16Array(br);
            m_extractedMotionMapping = des.ReadQSTransform(br);
            m_keepUnmappedLocal = br.ReadBoolean();
            br.Position += 3;
            m_mappingType = br.ReadInt32();
            br.Position += 8;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_skeletonA);
            s.WriteClassPointer(bw, m_skeletonB);
            s.WriteClassArray<hkaSkeletonMapperDataSimpleMapping>(bw, m_simpleMappings);
            s.WriteClassArray<hkaSkeletonMapperDataChainMapping>(bw, m_chainMappings);
            s.WriteInt16Array(bw, m_unmappedBones);
            s.WriteQSTransform(bw, m_extractedMotionMapping);
            bw.WriteBoolean(m_keepUnmappedLocal);
            bw.Position += 3;
            s.WriteInt32(bw, m_mappingType);
            bw.Position += 8;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_skeletonA = xd.ReadClassPointer<hkaSkeleton>(xe, nameof(m_skeletonA));
            m_skeletonB = xd.ReadClassPointer<hkaSkeleton>(xe, nameof(m_skeletonB));
            m_simpleMappings = xd.ReadClassArray<hkaSkeletonMapperDataSimpleMapping>(xe, nameof(m_simpleMappings));
            m_chainMappings = xd.ReadClassArray<hkaSkeletonMapperDataChainMapping>(xe, nameof(m_chainMappings));
            m_unmappedBones = xd.ReadInt16Array(xe, nameof(m_unmappedBones));
            m_extractedMotionMapping = xd.ReadQSTransform(xe, nameof(m_extractedMotionMapping));
            m_keepUnmappedLocal = xd.ReadBoolean(xe, nameof(m_keepUnmappedLocal));
            m_mappingType = xd.ReadFlag<MappingType, int>(xe, nameof(m_mappingType));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_skeletonA), m_skeletonA);
            xs.WriteClassPointer(xe, nameof(m_skeletonB), m_skeletonB);
            xs.WriteClassArray<hkaSkeletonMapperDataSimpleMapping>(xe, nameof(m_simpleMappings), m_simpleMappings);
            xs.WriteClassArray<hkaSkeletonMapperDataChainMapping>(xe, nameof(m_chainMappings), m_chainMappings);
            xs.WriteNumberArray(xe, nameof(m_unmappedBones), m_unmappedBones);
            xs.WriteQSTransform(xe, nameof(m_extractedMotionMapping), m_extractedMotionMapping);
            xs.WriteBoolean(xe, nameof(m_keepUnmappedLocal), m_keepUnmappedLocal);
            xs.WriteEnum<MappingType, int>(xe, nameof(m_mappingType), m_mappingType);
        }
    }
}

