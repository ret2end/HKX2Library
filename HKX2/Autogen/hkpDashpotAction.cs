using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDashpotAction Signatire: 0x50746c6e size: 128 flags: FLAGS_NONE

    // m_point m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 2 offset: 64 flags:  enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_impulse m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 

    public class hkpDashpotAction : hkpBinaryAction
    {

        public List<Vector4> m_point;
        public float m_strength;
        public float m_damping;
        public Vector4 m_impulse;

        public override uint Signature => 0x50746c6e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_point = des.ReadVector4CStyleArray(br, 4);//m_point = br.ReadVector4();
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.Position += 8;
            m_impulse = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVector4CStyleArray(bw, m_point);//bw.WriteVector4(m_point);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.Position += 8;
            bw.WriteVector4(m_impulse);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

