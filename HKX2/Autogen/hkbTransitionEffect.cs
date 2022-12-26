using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTransitionEffect Signatire: 0x945da157 size: 80 flags: FLAGS_NONE

    // m_selfTransitionMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 72 flags:  enum: SelfTransitionMode
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 73 flags:  enum: EventMode
    // m_defaultEventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 74 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbTransitionEffect : hkbGenerator
    {

        public sbyte m_selfTransitionMode;
        public sbyte m_eventMode;
        public sbyte m_defaultEventMode;

        public override uint Signature => 0x945da157;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_selfTransitionMode = br.ReadSByte();
            m_eventMode = br.ReadSByte();
            m_defaultEventMode = br.ReadSByte();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSByte(bw, m_selfTransitionMode);
            s.WriteSByte(bw, m_eventMode);
            s.WriteSByte(bw, m_defaultEventMode);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

