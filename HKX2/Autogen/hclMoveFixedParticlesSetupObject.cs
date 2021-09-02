namespace HKX2
{
    public class hclMoveFixedParticlesSetupObject : hclOperatorSetupObject
    {
        public hclBufferSetupObject m_displayBufferSetup;

        public string m_name;
        public hclSimClothSetupObject m_simClothSetupObject;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_simClothSetupObject = des.ReadClassPointer<hclSimClothSetupObject>(br);
            m_displayBufferSetup = des.ReadClassPointer<hclBufferSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_simClothSetupObject);
            s.WriteClassPointer(bw, m_displayBufferSetup);
        }
    }
}