using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineTimeInterval Signatire: 0x60a881e5 size: 16 flags: FLAGS_NONE

    // m_enterEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_exitEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_enterTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_exitTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkbStateMachineTimeInterval : IHavokObject
    {

        public int m_enterEventId;
        public int m_exitEventId;
        public float m_enterTime;
        public float m_exitTime;

        public uint Signature => 0x60a881e5;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_enterEventId = br.ReadInt32();
            m_exitEventId = br.ReadInt32();
            m_enterTime = br.ReadSingle();
            m_exitTime = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_enterEventId);
            bw.WriteInt32(m_exitEventId);
            bw.WriteSingle(m_enterTime);
            bw.WriteSingle(m_exitTime);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

