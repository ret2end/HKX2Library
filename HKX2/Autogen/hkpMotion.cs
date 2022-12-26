using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMotion Signatire: 0x98aadb4f size: 320 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags:  enum: MotionType
    // m_deactivationIntegrateCounter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 17 flags:  enum: 
    // m_deactivationNumInactiveFrames m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 2 offset: 18 flags:  enum: 
    // m_motionState m_class: hkMotionState Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_inertiaAndMassInv m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 208 flags:  enum: 
    // m_linearVelocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 224 flags:  enum: 
    // m_angularVelocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 240 flags:  enum: 
    // m_deactivationRefPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 2 offset: 256 flags:  enum: 
    // m_deactivationRefOrientation m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 2 offset: 288 flags:  enum: 
    // m_savedMotion m_class: hkpMaxSizeMotion Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 296 flags:  enum: 
    // m_savedQualityTypeIndex m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 304 flags:  enum: 
    // m_gravityFactor m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 306 flags:  enum: 

    public class hkpMotion : hkReferencedObject
    {

        public byte m_type;
        public byte m_deactivationIntegrateCounter;
        public List<ushort> m_deactivationNumInactiveFrames;
        public hkMotionState/*struct void*/ m_motionState;
        public Vector4 m_inertiaAndMassInv;
        public Vector4 m_linearVelocity;
        public Vector4 m_angularVelocity;
        public List<Vector4> m_deactivationRefPosition;
        public List<uint> m_deactivationRefOrientation;
        public hkpMaxSizeMotion /*pointer struct*/ m_savedMotion;
        public ushort m_savedQualityTypeIndex;
        public Half m_gravityFactor;

        public override uint Signature => 0x98aadb4f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_type = br.ReadByte();
            m_deactivationIntegrateCounter = br.ReadByte();
            m_deactivationNumInactiveFrames = des.ReadUInt16CStyleArray(br, 2);//m_deactivationNumInactiveFrames = br.ReadUInt16(); 2
            br.Position += 10;
            m_motionState = new hkMotionState();
            m_motionState.Read(des, br);
            m_inertiaAndMassInv = br.ReadVector4();
            m_linearVelocity = br.ReadVector4();
            m_angularVelocity = br.ReadVector4();
            m_deactivationRefPosition = des.ReadVector4CStyleArray(br, 2);//m_deactivationRefPosition = br.ReadVector4(); 2
            m_deactivationRefOrientation = des.ReadUInt32CStyleArray(br, 2);//m_deactivationRefOrientation = br.ReadUInt32(); 2
            m_savedMotion = des.ReadClassPointer<hkpMaxSizeMotion>(br);
            m_savedQualityTypeIndex = br.ReadUInt16();
            m_gravityFactor = br.ReadHalf();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_type);
            bw.WriteByte(m_deactivationIntegrateCounter);
            s.WriteUInt16CStyleArray(bw, m_deactivationNumInactiveFrames);//bw.WriteUInt16(m_deactivationNumInactiveFrames);
            bw.Position += 10;
            m_motionState.Write(s, bw);
            bw.WriteVector4(m_inertiaAndMassInv);
            bw.WriteVector4(m_linearVelocity);
            bw.WriteVector4(m_angularVelocity);
            s.WriteVector4CStyleArray(bw, m_deactivationRefPosition);//bw.WriteVector4(m_deactivationRefPosition);
            s.WriteUInt32CStyleArray(bw, m_deactivationRefOrientation);//bw.WriteUInt32(m_deactivationRefOrientation);
            s.WriteClassPointer(bw, m_savedMotion);
            bw.WriteUInt16(m_savedQualityTypeIndex);
            bw.WriteHalf(m_gravityFactor);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
