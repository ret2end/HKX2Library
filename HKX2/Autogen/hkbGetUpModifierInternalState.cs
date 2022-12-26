using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbGetUpModifierInternalState Signatire: 0xd84cad4a size: 32 flags: FLAGS_NONE

    // m_timeSinceBegin m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_initNextModify m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbGetUpModifierInternalState : hkReferencedObject
    {

        public float m_timeSinceBegin;
        public float m_timeStep;
        public bool m_initNextModify;

        public override uint Signature => 0xd84cad4a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_timeSinceBegin = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            m_initNextModify = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_timeSinceBegin);
            bw.WriteSingle(m_timeStep);
            bw.WriteBoolean(m_initNextModify);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

