namespace HKX2
{
    public class hkpConvexTransformShapeBase : hkpConvexShape
    {
        public hkpSingleShapeContainer m_childShape;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des, br);
            br.ReadInt32(); // childShapeSizeForSpu

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_childShape.Write(s, bw);
            bw.WriteInt32(0); // childShapeSizeForSpu

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}