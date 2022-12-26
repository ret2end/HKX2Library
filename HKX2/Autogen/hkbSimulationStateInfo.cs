using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSimulationStateInfo Signatire: 0xa40822b4 size: 24 flags: FLAGS_NONE

    // m_simulationState m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags:  enum: SimulationState
    
    public class hkbSimulationStateInfo : hkReferencedObject
    {

        public byte m_simulationState;

        public override uint Signature => 0xa40822b4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_simulationState = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_simulationState);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

