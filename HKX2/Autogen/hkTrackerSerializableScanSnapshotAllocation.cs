using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkTrackerSerializableScanSnapshotAllocation Signatire: 0x9ab3a6ac size: 24 flags: FLAGS_NONE

    // m_start m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_size m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_traceId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkTrackerSerializableScanSnapshotAllocation : IHavokObject
    {

        public ulong m_start;
        public ulong m_size;
        public int m_traceId;

        public uint Signature => 0x9ab3a6ac;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_start = br.ReadUInt64();
            m_size = br.ReadUInt64();
            m_traceId = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt64(m_start);
            bw.WriteUInt64(m_size);
            bw.WriteInt32(m_traceId);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

