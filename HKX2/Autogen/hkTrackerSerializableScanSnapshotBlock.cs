using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkTrackerSerializableScanSnapshotBlock Signatire: 0xe7f23e6d size: 40 flags: FLAGS_NONE

    // m_typeIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_start m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_size m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_arraySize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_startReferenceIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_numReferences m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkTrackerSerializableScanSnapshotBlock : IHavokObject
    {

        public int m_typeIndex;
        public ulong m_start;
        public ulong m_size;
        public int m_arraySize;
        public int m_startReferenceIndex;
        public int m_numReferences;

        public uint Signature => 0xe7f23e6d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_typeIndex = br.ReadInt32();
            br.Position += 4;
            m_start = br.ReadUInt64();
            m_size = br.ReadUInt64();
            m_arraySize = br.ReadInt32();
            m_startReferenceIndex = br.ReadInt32();
            m_numReferences = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_typeIndex);
            bw.Position += 4;
            bw.WriteUInt64(m_start);
            bw.WriteUInt64(m_size);
            bw.WriteInt32(m_arraySize);
            bw.WriteInt32(m_startReferenceIndex);
            bw.WriteInt32(m_numReferences);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

