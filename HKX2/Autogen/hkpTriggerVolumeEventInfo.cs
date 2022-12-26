using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTriggerVolumeEventInfo Signatire: 0xeb60f431 size: 24 flags: FLAGS_NONE

    // m_sortValue m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_body m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    // m_operation m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: Operation
    
    public class hkpTriggerVolumeEventInfo : IHavokObject
    {

        public ulong m_sortValue;
        public hkpRigidBody /*pointer struct*/ m_body;
        public int m_operation;

        public uint Signature => 0xeb60f431;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_sortValue = br.ReadUInt64();
            m_body = des.ReadClassPointer<hkpRigidBody>(br);
            m_operation = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt64(m_sortValue);
            s.WriteClassPointer(bw, m_body);
            s.WriteInt32(bw, m_operation);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

