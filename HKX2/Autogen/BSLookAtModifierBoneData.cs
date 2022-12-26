using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSLookAtModifierBoneData Signatire: 0x29efee59 size: 64 flags: FLAGS_NONE

    // m_index m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_fwdAxisLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_limitAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_onGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_offGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_enabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    // m_currentFwdAxisLS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSLookAtModifierBoneData : IHavokObject
    {

        public short m_index;
        public Vector4 m_fwdAxisLS;
        public float m_limitAngleDegrees;
        public float m_onGain;
        public float m_offGain;
        public bool m_enabled;
        public Vector4 m_currentFwdAxisLS;

        public uint Signature => 0x29efee59;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_index = br.ReadInt16();
            br.Position += 14;
            m_fwdAxisLS = br.ReadVector4();
            m_limitAngleDegrees = br.ReadSingle();
            m_onGain = br.ReadSingle();
            m_offGain = br.ReadSingle();
            m_enabled = br.ReadBoolean();
            br.Position += 3;
            m_currentFwdAxisLS = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt16(m_index);
            bw.Position += 14;
            bw.WriteVector4(m_fwdAxisLS);
            bw.WriteSingle(m_limitAngleDegrees);
            bw.WriteSingle(m_onGain);
            bw.WriteSingle(m_offGain);
            bw.WriteBoolean(m_enabled);
            bw.Position += 3;
            bw.WriteVector4(m_currentFwdAxisLS);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

