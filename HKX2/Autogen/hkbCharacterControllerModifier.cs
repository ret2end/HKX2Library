using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterControllerModifier Signatire: 0xf675d6fb size: 176 flags: FLAGS_NONE

    // m_controlData m_class: hkbCharacterControllerControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_initialVelocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_initialVelocityCoordinates m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 128 flags:  enum: InitialVelocityCoordinates
    // m_motionMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 129 flags:  enum: MotionMode
    // m_forceDownwardMomentum m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 130 flags:  enum: 
    // m_applyGravity m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 131 flags:  enum: 
    // m_setInitialVelocity m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    // m_isTouchingGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 133 flags:  enum: 
    // m_gravity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timestep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_isInitialVelocityAdded m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 164 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbCharacterControllerModifier : hkbModifier
    {

        public hkbCharacterControllerControlData/*struct void*/ m_controlData;
        public Vector4 m_initialVelocity;
        public sbyte m_initialVelocityCoordinates;
        public sbyte m_motionMode;
        public bool m_forceDownwardMomentum;
        public bool m_applyGravity;
        public bool m_setInitialVelocity;
        public bool m_isTouchingGround;
        public Vector4 m_gravity;
        public float m_timestep;
        public bool m_isInitialVelocityAdded;

        public override uint Signature => 0xf675d6fb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_controlData = new hkbCharacterControllerControlData();
            m_controlData.Read(des,br);
            m_initialVelocity = br.ReadVector4();
            m_initialVelocityCoordinates = br.ReadSByte();
            m_motionMode = br.ReadSByte();
            m_forceDownwardMomentum = br.ReadBoolean();
            m_applyGravity = br.ReadBoolean();
            m_setInitialVelocity = br.ReadBoolean();
            m_isTouchingGround = br.ReadBoolean();
            br.Position += 10;
            m_gravity = br.ReadVector4();
            m_timestep = br.ReadSingle();
            m_isInitialVelocityAdded = br.ReadBoolean();
            br.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_controlData.Write(s, bw);
            bw.WriteVector4(m_initialVelocity);
            s.WriteSByte(bw, m_initialVelocityCoordinates);
            s.WriteSByte(bw, m_motionMode);
            bw.WriteBoolean(m_forceDownwardMomentum);
            bw.WriteBoolean(m_applyGravity);
            bw.WriteBoolean(m_setInitialVelocity);
            bw.WriteBoolean(m_isTouchingGround);
            bw.Position += 10;
            bw.WriteVector4(m_gravity);
            bw.WriteSingle(m_timestep);
            bw.WriteBoolean(m_isInitialVelocityAdded);
            bw.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

