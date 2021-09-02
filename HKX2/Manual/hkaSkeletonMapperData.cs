using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum MappingType
    {
        HK_RAGDOLL_MAPPING = 0,
        HK_RETARGETING_MAPPING = 1
    }

    public class hkaSkeletonMapperData : IHavokObject
    {
        public List<hkaSkeletonMapperDataPartitionMappingRange> m_chainMappingPartitionRanges;
        public List<hkaSkeletonMapperDataChainMapping> m_chainMappings;
        public Matrix4x4 m_extractedMotionMapping;
        public bool m_keepUnmappedLocal;
        public MappingType m_mappingType;
        public List<short> m_partitionMap;
        public List<hkaSkeletonMapperDataPartitionMappingRange> m_simpleMappingPartitionRanges;
        public List<hkaSkeletonMapperDataSimpleMapping> m_simpleMappings;

        public hkaSkeleton m_skeletonA;
        public hkaSkeleton m_skeletonB;
        public List<short> m_unmappedBones;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_skeletonA = des.ReadClassPointer<hkaSkeleton>(br);
            m_skeletonB = des.ReadClassPointer<hkaSkeleton>(br);
            m_partitionMap = des.ReadInt16Array(br);
            m_simpleMappingPartitionRanges = des.ReadClassArray<hkaSkeletonMapperDataPartitionMappingRange>(br);
            m_chainMappingPartitionRanges = des.ReadClassArray<hkaSkeletonMapperDataPartitionMappingRange>(br);
            m_simpleMappings = des.ReadClassArray<hkaSkeletonMapperDataSimpleMapping>(br);
            m_chainMappings = des.ReadClassArray<hkaSkeletonMapperDataChainMapping>(br);
            m_unmappedBones = des.ReadInt16Array(br);
            m_extractedMotionMapping = des.ReadQSTransform(br);
            m_keepUnmappedLocal = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();
            m_mappingType = (MappingType) br.ReadInt32();
            br.ReadUSize();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_skeletonA);
            s.WriteClassPointer(bw, m_skeletonB);
            s.WriteInt16Array(bw, m_partitionMap);
            s.WriteClassArray(bw, m_simpleMappingPartitionRanges);
            s.WriteClassArray(bw, m_chainMappingPartitionRanges);
            s.WriteClassArray(bw, m_simpleMappings);
            s.WriteClassArray(bw, m_chainMappings);
            s.WriteInt16Array(bw, m_unmappedBones);
            s.WriteQSTransform(bw, m_extractedMotionMapping);
            bw.WriteBoolean(m_keepUnmappedLocal);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
            bw.WriteInt32((int) m_mappingType);
            bw.WriteUSize(0);
        }
    }
}