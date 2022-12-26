using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkTrackerSerializableScanSnapshot Signatire: 0x875af1d9 size: 128 flags: FLAGS_NONE

    // m_allocations m_class: hkTrackerSerializableScanSnapshotAllocation Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_blocks m_class: hkTrackerSerializableScanSnapshotBlock Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_refs m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 48 flags:  enum: 
    // m_typeNames m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 64 flags:  enum: 
    // m_traceText m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 80 flags:  enum: 
    // m_traceAddrs m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 96 flags:  enum: 
    // m_traceParents m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 112 flags:  enum: 
    
    public class hkTrackerSerializableScanSnapshot : hkReferencedObject
    {

        public List<hkTrackerSerializableScanSnapshotAllocation> m_allocations;
        public List<hkTrackerSerializableScanSnapshotBlock> m_blocks;
        public List<int> m_refs;
        public List<byte> m_typeNames;
        public List<byte> m_traceText;
        public List<ulong> m_traceAddrs;
        public List<int> m_traceParents;

        public override uint Signature => 0x875af1d9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_allocations = des.ReadClassArray<hkTrackerSerializableScanSnapshotAllocation>(br);
            m_blocks = des.ReadClassArray<hkTrackerSerializableScanSnapshotBlock>(br);
            m_refs = des.ReadInt32Array(br);
            m_typeNames = des.ReadByteArray(br);
            m_traceText = des.ReadByteArray(br);
            m_traceAddrs = des.ReadUInt64Array(br);
            m_traceParents = des.ReadInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkTrackerSerializableScanSnapshotAllocation>(bw, m_allocations);
            s.WriteClassArray<hkTrackerSerializableScanSnapshotBlock>(bw, m_blocks);
            s.WriteInt32Array(bw, m_refs);
            s.WriteByteArray(bw, m_typeNames);
            s.WriteByteArray(bw, m_traceText);
            s.WriteUInt64Array(bw, m_traceAddrs);
            s.WriteInt32Array(bw, m_traceParents);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

