using System.Collections.Generic;

namespace HKX2
{
    public class hclStorageSetupMeshSectionBoneInfluences : hkReferencedObject
    {
        public List<uint> m_boneIndices;
        public List<float> m_weights;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_boneIndices = des.ReadUInt32Array(br);
            m_weights = des.ReadSingleArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_boneIndices);
            s.WriteSingleArray(bw, m_weights);
        }
    }
}