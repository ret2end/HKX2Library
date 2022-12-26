using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSkeletonMapperData Signatire: 0x95687ea0 size: 128 flags: FLAGS_NONE

    // m_skeletonA m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_skeletonB m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    // m_simpleMappings m_class: hkaSkeletonMapperDataSimpleMapping Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_chainMappings m_class: hkaSkeletonMapperDataChainMapping Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_unmappedBones m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_extractedMotionMapping m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_keepUnmappedLocal m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_mappingType m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 116 flags:  enum: MappingType
    
    public class hkaSkeletonMapperData : IHavokObject
    {

        public hkaSkeleton /*pointer struct*/ m_skeletonA;
        public hkaSkeleton /*pointer struct*/ m_skeletonB;
        public List<hkaSkeletonMapperDataSimpleMapping> m_simpleMappings;
        public List<hkaSkeletonMapperDataChainMapping> m_chainMappings;
        public List<short> m_unmappedBones;
        public Matrix4x4 m_extractedMotionMapping;
        public bool m_keepUnmappedLocal;
        public int m_mappingType;

        public uint Signature => 0x95687ea0;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
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

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

