namespace HKX2
{
    public class hclSimClothBufferSetupObject : hclBufferSetupObject
    {
        public enum Type
        {
            SIM_CLOTH_MESH_CURRENT_POSITIONS = 0,
            SIM_CLOTH_MESH_PREVIOUS_POSITIONS = 1,
            SIM_CLOTH_MESH_ORIGINAL_POSE = 2
        }

        public string m_name;
        public hclSimClothSetupObject m_simClothSetupObject;

        public Type m_type;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = (Type) br.ReadUInt32();
            m_name = des.ReadStringPointer(br);
            m_simClothSetupObject = des.ReadClassPointer<hclSimClothSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32((uint) m_type);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_simClothSetupObject);
        }
    }
}