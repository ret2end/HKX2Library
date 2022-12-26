using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbManualSelectorGeneratorInternalState Signatire: 0x492c6137 size: 24 flags: FLAGS_NONE

    // m_currentGeneratorIndex m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbManualSelectorGeneratorInternalState : hkReferencedObject
    {

        public sbyte m_currentGeneratorIndex;

        public override uint Signature => 0x492c6137;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_currentGeneratorIndex = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSByte(m_currentGeneratorIndex);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

