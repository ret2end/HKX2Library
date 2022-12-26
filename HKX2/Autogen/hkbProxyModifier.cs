using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbProxyModifier Signatire: 0x8a41554f size: 288 flags: FLAGS_NONE

    // m_proxyInfo m_class: hkbProxyModifierProxyInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_linearVelocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_horizontalGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_verticalGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 180 flags:  enum: 
    // m_maxHorizontalSeparation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_maxVerticalSeparation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags:  enum: 
    // m_verticalDisplacementError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 192 flags:  enum: 
    // m_verticalDisplacementErrorGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 196 flags:  enum: 
    // m_maxVerticalDisplacement m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 200 flags:  enum: 
    // m_minVerticalDisplacement m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 204 flags:  enum: 
    // m_capsuleHeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 208 flags:  enum: 
    // m_capsuleRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 212 flags:  enum: 
    // m_maxSlopeForRotation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 216 flags:  enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 220 flags:  enum: 
    // m_phantomType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 224 flags:  enum: PhantomType
    // m_linearVelocityMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 225 flags:  enum: LinearVelocityMode
    // m_ignoreIncomingRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 226 flags:  enum: 
    // m_ignoreCollisionDuringRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 227 flags:  enum: 
    // m_ignoreIncomingTranslation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 228 flags:  enum: 
    // m_includeDownwardMomentum m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 229 flags:  enum: 
    // m_followWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 230 flags:  enum: 
    // m_isTouchingGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 231 flags:  enum: 
    // m_characterProxy m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_phantom m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 240 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_phantomShape m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 248 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_horizontalDisplacement m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 256 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_verticalDisplacement m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 272 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timestep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 276 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_previousFrameFollowWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 280 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbProxyModifier : hkbModifier
    {

        public hkbProxyModifierProxyInfo/*struct void*/ m_proxyInfo;
        public Vector4 m_linearVelocity;
        public float m_horizontalGain;
        public float m_verticalGain;
        public float m_maxHorizontalSeparation;
        public float m_maxVerticalSeparation;
        public float m_verticalDisplacementError;
        public float m_verticalDisplacementErrorGain;
        public float m_maxVerticalDisplacement;
        public float m_minVerticalDisplacement;
        public float m_capsuleHeight;
        public float m_capsuleRadius;
        public float m_maxSlopeForRotation;
        public uint m_collisionFilterInfo;
        public sbyte m_phantomType;
        public sbyte m_linearVelocityMode;
        public bool m_ignoreIncomingRotation;
        public bool m_ignoreCollisionDuringRotation;
        public bool m_ignoreIncomingTranslation;
        public bool m_includeDownwardMomentum;
        public bool m_followWorldFromModel;
        public bool m_isTouchingGround;
        public dynamic /* POINTER VOID */ m_characterProxy;
        public dynamic /* POINTER VOID */ m_phantom;
        public dynamic /* POINTER VOID */ m_phantomShape;
        public Vector4 m_horizontalDisplacement;
        public float m_verticalDisplacement;
        public float m_timestep;
        public bool m_previousFrameFollowWorldFromModel;

        public override uint Signature => 0x8a41554f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_proxyInfo = new hkbProxyModifierProxyInfo();
            m_proxyInfo.Read(des,br);
            m_linearVelocity = br.ReadVector4();
            m_horizontalGain = br.ReadSingle();
            m_verticalGain = br.ReadSingle();
            m_maxHorizontalSeparation = br.ReadSingle();
            m_maxVerticalSeparation = br.ReadSingle();
            m_verticalDisplacementError = br.ReadSingle();
            m_verticalDisplacementErrorGain = br.ReadSingle();
            m_maxVerticalDisplacement = br.ReadSingle();
            m_minVerticalDisplacement = br.ReadSingle();
            m_capsuleHeight = br.ReadSingle();
            m_capsuleRadius = br.ReadSingle();
            m_maxSlopeForRotation = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            m_phantomType = br.ReadSByte();
            m_linearVelocityMode = br.ReadSByte();
            m_ignoreIncomingRotation = br.ReadBoolean();
            m_ignoreCollisionDuringRotation = br.ReadBoolean();
            m_ignoreIncomingTranslation = br.ReadBoolean();
            m_includeDownwardMomentum = br.ReadBoolean();
            m_followWorldFromModel = br.ReadBoolean();
            m_isTouchingGround = br.ReadBoolean();
            des.ReadEmptyPointer(br);/* m_characterProxy POINTER VOID */
            des.ReadEmptyPointer(br);/* m_phantom POINTER VOID */
            des.ReadEmptyPointer(br);/* m_phantomShape POINTER VOID */
            m_horizontalDisplacement = br.ReadVector4();
            m_verticalDisplacement = br.ReadSingle();
            m_timestep = br.ReadSingle();
            m_previousFrameFollowWorldFromModel = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_proxyInfo.Write(s, bw);
            bw.WriteVector4(m_linearVelocity);
            bw.WriteSingle(m_horizontalGain);
            bw.WriteSingle(m_verticalGain);
            bw.WriteSingle(m_maxHorizontalSeparation);
            bw.WriteSingle(m_maxVerticalSeparation);
            bw.WriteSingle(m_verticalDisplacementError);
            bw.WriteSingle(m_verticalDisplacementErrorGain);
            bw.WriteSingle(m_maxVerticalDisplacement);
            bw.WriteSingle(m_minVerticalDisplacement);
            bw.WriteSingle(m_capsuleHeight);
            bw.WriteSingle(m_capsuleRadius);
            bw.WriteSingle(m_maxSlopeForRotation);
            bw.WriteUInt32(m_collisionFilterInfo);
            s.WriteSByte(bw, m_phantomType);
            s.WriteSByte(bw, m_linearVelocityMode);
            bw.WriteBoolean(m_ignoreIncomingRotation);
            bw.WriteBoolean(m_ignoreCollisionDuringRotation);
            bw.WriteBoolean(m_ignoreIncomingTranslation);
            bw.WriteBoolean(m_includeDownwardMomentum);
            bw.WriteBoolean(m_followWorldFromModel);
            bw.WriteBoolean(m_isTouchingGround);
            s.WriteVoidPointer(bw);/* m_characterProxy POINTER VOID */
            s.WriteVoidPointer(bw);/* m_phantom POINTER VOID */
            s.WriteVoidPointer(bw);/* m_phantomShape POINTER VOID */
            bw.WriteVector4(m_horizontalDisplacement);
            bw.WriteSingle(m_verticalDisplacement);
            bw.WriteSingle(m_timestep);
            bw.WriteBoolean(m_previousFrameFollowWorldFromModel);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
