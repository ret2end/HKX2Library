using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkaSkeleton : hkReferencedObject
    {
        public List<hkaBone> m_bones;
        public List<string> m_floatSlots;
        public List<hkaSkeletonLocalFrameOnBone> m_localFrames;

        public string m_name;
        public List<short> m_parentIndices;
        public List<hkaSkeletonPartition> m_partitions;
        public List<float> m_referenceFloats;
        public List<Matrix4x4> m_referencePose;
        public override uint Signature => 0xFEC1CEDB;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_parentIndices = des.ReadInt16Array(br);
            m_bones = des.ReadClassArray<hkaBone>(br);
            m_referencePose = des.ReadQSTransformArray(br);
            m_referenceFloats = des.ReadSingleArray(br);
            m_floatSlots = des.ReadStringPointerArray(br);
            m_localFrames = des.ReadClassArray<hkaSkeletonLocalFrameOnBone>(br);
            m_partitions = des.ReadClassArray<hkaSkeletonPartition>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteInt16Array(bw, m_parentIndices);
            s.WriteClassArray(bw, m_bones);
            s.WriteQSTransformArray(bw, m_referencePose);
            s.WriteSingleArray(bw, m_referenceFloats);
            s.WriteStringPointerArray(bw, m_floatSlots);
            s.WriteClassArray(bw, m_localFrames);
            s.WriteClassArray(bw, m_partitions);
        }
    }
}