using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbGeneratorSyncInfoSyncPoint Signatire: 0xb597cf92 size: 8 flags: FLAGS_NONE

    // m_id m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkbGeneratorSyncInfoSyncPoint : IHavokObject
    {

        public int m_id;
        public float m_time;

        public uint Signature => 0xb597cf92;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_id = br.ReadInt32();
            m_time = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_id);
            bw.WriteSingle(m_time);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

