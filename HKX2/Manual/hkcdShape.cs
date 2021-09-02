namespace HKX2
{
    public class hkcdShape : hkReferencedObject
    {
        public byte m_bitsPerKey;

        public ShapeDispatchTypeEnum m_dispatchType;
        public ShapeInfoCodecTypeEnum m_shapeInfoCodecType;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            br.ReadByte(); // type
            m_dispatchType = (ShapeDispatchTypeEnum) br.ReadByte();
            m_bitsPerKey = br.ReadByte();
            m_shapeInfoCodecType = (ShapeInfoCodecTypeEnum) br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteByte(0); // type
            bw.WriteByte((byte) m_dispatchType);
            bw.WriteByte(m_bitsPerKey);
            bw.WriteByte((byte) m_shapeInfoCodecType);
        }
    }
}