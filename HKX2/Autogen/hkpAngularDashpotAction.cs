using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAngularDashpotAction Signatire: 0x35f4c487 size: 96 flags: FLAGS_NONE

    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_damping m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    
    public class hkpAngularDashpotAction : hkpBinaryAction
    {

        public Quaternion m_rotation;
        public float m_strength;
        public float m_damping;

        public override uint Signature => 0x35f4c487;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rotation = des.ReadQuaternion(br);
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotation);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

