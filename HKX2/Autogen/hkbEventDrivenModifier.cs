using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventDrivenModifier Signatire: 0x7ed3f44e size: 104 flags: FLAGS_NONE

    // m_activateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_deactivateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_activeByDefault m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 97 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbEventDrivenModifier : hkbModifierWrapper
    {

        public int m_activateEventId;
        public int m_deactivateEventId;
        public bool m_activeByDefault;
        public bool m_isActive;

        public override uint Signature => 0x7ed3f44e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_activateEventId = br.ReadInt32();
            m_deactivateEventId = br.ReadInt32();
            m_activeByDefault = br.ReadBoolean();
            m_isActive = br.ReadBoolean();
            br.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_activateEventId);
            bw.WriteInt32(m_deactivateEventId);
            bw.WriteBoolean(m_activeByDefault);
            bw.WriteBoolean(m_isActive);
            bw.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

