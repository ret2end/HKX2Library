using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCallbackConstraintMotor Signatire: 0xafcd79ad size: 72 flags: FLAGS_NONE

    // m_callbackFunc m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 32 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_callbackType m_class:  Type.TYPE_ENUM Type.TYPE_UINT32 arrSize: 0 offset: 40 flags:  enum: CallbackType
    // m_userData0 m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_userData1 m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_userData2 m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpCallbackConstraintMotor : hkpLimitedForceConstraintMotor
    {

        public dynamic /* POINTER VOID */ m_callbackFunc;
        public uint m_callbackType;
        public ulong m_userData0;
        public ulong m_userData1;
        public ulong m_userData2;

        public override uint Signature => 0xafcd79ad;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_callbackFunc POINTER VOID */
            m_callbackType = br.ReadUInt32();
            br.Position += 4;
            m_userData0 = br.ReadUInt64();
            m_userData1 = br.ReadUInt64();
            m_userData2 = br.ReadUInt64();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_callbackFunc POINTER VOID */
            s.WriteUInt32(bw, m_callbackType);
            bw.Position += 4;
            bw.WriteUInt64(m_userData0);
            bw.WriteUInt64(m_userData1);
            bw.WriteUInt64(m_userData2);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

