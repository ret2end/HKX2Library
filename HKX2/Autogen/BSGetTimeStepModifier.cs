using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSGetTimeStepModifier Signatire: 0xbda33bfe size: 88 flags: FLAGS_NONE

    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class BSGetTimeStepModifier : hkbModifier
    {

        public float m_timeStep;

        public override uint Signature => 0xbda33bfe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_timeStep = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_timeStep);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

