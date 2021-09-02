using System.Collections.Generic;

namespace HKX2
{
    public class hclMeshBoneDeformSetupObject : hclOperatorSetupObject
    {
        public List<string> m_deformedBones;
        public hclBufferSetupObject m_inputBufferSetupObject;
        public hclTriangleSelectionInput m_inputTriangleSelection;
        public uint m_maxTrianglesPerBone;
        public float m_minimumTriangleWeight;

        public string m_name;
        public hclTransformSetSetupObject m_outputTransformSetSetupObject;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_inputBufferSetupObject = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_inputTriangleSelection = new hclTriangleSelectionInput();
            m_inputTriangleSelection.Read(des, br);
            m_outputTransformSetSetupObject = des.ReadClassPointer<hclTransformSetSetupObject>(br);
            m_deformedBones = des.ReadStringPointerArray(br);
            m_maxTrianglesPerBone = br.ReadUInt32();
            m_minimumTriangleWeight = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_inputBufferSetupObject);
            m_inputTriangleSelection.Write(s, bw);
            s.WriteClassPointer(bw, m_outputTransformSetSetupObject);
            s.WriteStringPointerArray(bw, m_deformedBones);
            bw.WriteUInt32(m_maxTrianglesPerBone);
            bw.WriteSingle(m_minimumTriangleWeight);
        }
    }
}