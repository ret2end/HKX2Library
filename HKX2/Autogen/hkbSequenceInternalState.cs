using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSequenceInternalState Signatire: 0x419b9a05 size: 88 flags: FLAGS_NONE

    // m_nextSampleEvents m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: 
    // m_nextSampleReals m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 32 flags:  enum: 
    // m_nextSampleBools m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 48 flags:  enum: 
    // m_nextSampleInts m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 64 flags:  enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    
    public class hkbSequenceInternalState : hkReferencedObject
    {

        public List<int> m_nextSampleEvents;
        public List<int> m_nextSampleReals;
        public List<int> m_nextSampleBools;
        public List<int> m_nextSampleInts;
        public float m_time;
        public bool m_isEnabled;

        public override uint Signature => 0x419b9a05;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_nextSampleEvents = des.ReadInt32Array(br);
            m_nextSampleReals = des.ReadInt32Array(br);
            m_nextSampleBools = des.ReadInt32Array(br);
            m_nextSampleInts = des.ReadInt32Array(br);
            m_time = br.ReadSingle();
            m_isEnabled = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt32Array(bw, m_nextSampleEvents);
            s.WriteInt32Array(bw, m_nextSampleReals);
            s.WriteInt32Array(bw, m_nextSampleBools);
            s.WriteInt32Array(bw, m_nextSampleInts);
            bw.WriteSingle(m_time);
            bw.WriteBoolean(m_isEnabled);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

