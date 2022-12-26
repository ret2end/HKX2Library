using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSimulationControlCommand Signatire: 0x2a241367 size: 24 flags: FLAGS_NONE

    // m_command m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags:  enum: SimulationControlCommand
    
    public class hkbSimulationControlCommand : hkReferencedObject
    {

        public byte m_command;

        public override uint Signature => 0x2a241367;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_command = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_command);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
