namespace HKX2
{
    public class hkaiSilhouetteGeneratorSectionContext : IHavokObject
    {
        public bool m_generatedLastFrame;
        public bool m_generatingThisFrame;
        public hkaiSilhouetteGenerator m_generator;

        public hkQTransform m_lastRelativeTransform;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_lastRelativeTransform = new hkQTransform();
            m_lastRelativeTransform.Read(des, br);
            m_generator = des.ReadClassPointer<hkaiSilhouetteGenerator>(br);
            br.ReadUInt32();
            m_generatedLastFrame = br.ReadBoolean();
            m_generatingThisFrame = br.ReadBoolean();
            br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_lastRelativeTransform.Write(s, bw);
            s.WriteClassPointer(bw, m_generator);
            bw.WriteUInt32(0);
            bw.WriteBoolean(m_generatedLastFrame);
            bw.WriteBoolean(m_generatingThisFrame);
            bw.WriteUInt16(0);
        }
    }
}