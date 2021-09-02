using System.Numerics;

namespace HKX2
{
    public class hkpMovingSurfaceModifierConstraintAtom : hkpModifierConstraintAtom
    {
        public Vector4 m_velocity;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_velocity = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4(bw, m_velocity);
        }
    }
}