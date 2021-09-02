namespace HKX2
{
    public class hkpModifierConstraintAtom : hkpConstraintAtom
    {
        public hkpConstraintAtom m_child;
        public ushort m_childSize;

        public ushort m_modifierAtomSize;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_modifierAtomSize = br.ReadUInt16();
            m_childSize = br.ReadUInt16();
            m_child = des.ReadClassPointer<hkpConstraintAtom>(br);
            br.ReadUInt64(); // pad_0,1
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            bw.WriteUInt16(m_modifierAtomSize);
            bw.WriteUInt16(m_childSize);
            s.WriteClassPointer(bw, m_child);
            bw.WriteUInt64(0); // pad_0,1
        }
    }
}