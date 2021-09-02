namespace HKX2
{
    public class hkcdPlanarCsgOperand : hkReferencedObject
    {
        public hkcdPlanarGeometry m_danglingGeometry;

        public hkcdPlanarSolid m_solid;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_solid = des.ReadClassPointer<hkcdPlanarSolid>(br);
            m_danglingGeometry = des.ReadClassPointer<hkcdPlanarGeometry>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_solid);
            s.WriteClassPointer(bw, m_danglingGeometry);
            bw.WriteUInt64(0);
        }
    }
}