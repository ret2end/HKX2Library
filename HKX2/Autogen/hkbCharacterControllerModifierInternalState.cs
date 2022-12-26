using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterControllerModifierInternalState Signatire: 0xf8dfec0d size: 48 flags: FLAGS_NONE

    // m_gravity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_timestep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_isInitialVelocityAdded m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_isTouchingGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 37 flags:  enum: 
    
    public class hkbCharacterControllerModifierInternalState : hkReferencedObject
    {

        public Vector4 m_gravity;
        public float m_timestep;
        public bool m_isInitialVelocityAdded;
        public bool m_isTouchingGround;

        public override uint Signature => 0xf8dfec0d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_gravity = br.ReadVector4();
            m_timestep = br.ReadSingle();
            m_isInitialVelocityAdded = br.ReadBoolean();
            m_isTouchingGround = br.ReadBoolean();
            br.Position += 10;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_gravity);
            bw.WriteSingle(m_timestep);
            bw.WriteBoolean(m_isInitialVelocityAdded);
            bw.WriteBoolean(m_isTouchingGround);
            bw.Position += 10;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

