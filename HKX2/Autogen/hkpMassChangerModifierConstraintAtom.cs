using System.Numerics;

namespace HKX2
{
    public class hkpMassChangerModifierConstraintAtom : hkpModifierConstraintAtom
    {
        public Vector4 m_factorA;
        public Vector4 m_factorB;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_factorA = des.ReadVector4(br);
            m_factorB = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4(bw, m_factorA);
            s.WriteVector4(bw, m_factorB);
        }
    }
}