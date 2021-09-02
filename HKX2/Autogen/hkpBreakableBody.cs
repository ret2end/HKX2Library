namespace HKX2
{
    public class hkpBreakableBody : hkReferencedObject
    {
        public byte m_bodyTypeAndFlags;
        public hkpBreakableShape m_breakableShape;
        public short m_constraintStrength;

        public hkpBreakableBodyController m_controller;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_controller = des.ReadClassPointer<hkpBreakableBodyController>(br);
            m_breakableShape = des.ReadClassPointer<hkpBreakableShape>(br);
            m_bodyTypeAndFlags = br.ReadByte();
            br.ReadByte();
            m_constraintStrength = br.ReadInt16();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_controller);
            s.WriteClassPointer(bw, m_breakableShape);
            bw.WriteByte(m_bodyTypeAndFlags);
            bw.WriteByte(0);
            bw.WriteInt16(m_constraintStrength);
            bw.WriteUInt32(0);
        }
    }
}