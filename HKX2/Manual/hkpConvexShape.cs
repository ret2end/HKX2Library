namespace HKX2
{
    public enum WeldResult
    {
        WELD_RESULT_REJECT_CONTACT_POINT = 0,
        WELD_RESULT_ACCEPT_CONTACT_POINT_MODIFIED = 1,
        WELD_RESULT_ACCEPT_CONTACT_POINT_UNMODIFIED = 2
    }

    public class hkpConvexShape : hkpSphereRepShape
    {
        public float m_radius;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_radius = br.ReadSingle();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_radius);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}