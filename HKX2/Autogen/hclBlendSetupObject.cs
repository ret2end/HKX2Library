namespace HKX2
{
    public class hclBlendSetupObject : hclOperatorSetupObject
    {
        public hclBufferSetupObject m_A;
        public hclBufferSetupObject m_B;
        public bool m_blendBitangents;
        public bool m_blendNormals;
        public bool m_blendTangents;
        public hclVertexFloatInput m_blendWeights;
        public hclBufferSetupObject m_C;
        public bool m_mapToScurve;

        public string m_name;
        public hclVertexSelectionInput m_vertexSelection;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_A = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_B = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_C = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_vertexSelection = new hclVertexSelectionInput();
            m_vertexSelection.Read(des, br);
            m_blendWeights = new hclVertexFloatInput();
            m_blendWeights.Read(des, br);
            m_mapToScurve = br.ReadBoolean();
            m_blendNormals = br.ReadBoolean();
            m_blendTangents = br.ReadBoolean();
            m_blendBitangents = br.ReadBoolean();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_A);
            s.WriteClassPointer(bw, m_B);
            s.WriteClassPointer(bw, m_C);
            m_vertexSelection.Write(s, bw);
            m_blendWeights.Write(s, bw);
            bw.WriteBoolean(m_mapToScurve);
            bw.WriteBoolean(m_blendNormals);
            bw.WriteBoolean(m_blendTangents);
            bw.WriteBoolean(m_blendBitangents);
            bw.WriteUInt32(0);
        }
    }
}