using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSenseHandleModifierRange Signatire: 0xfb56b692 size: 32 flags: FLAGS_NONE

    // m_event m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_minDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_maxDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_ignoreHandle m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbSenseHandleModifierRange : IHavokObject
    {

        public hkbEventProperty/*struct void*/ m_event;
        public float m_minDistance;
        public float m_maxDistance;
        public bool m_ignoreHandle;

        public uint Signature => 0xfb56b692;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_event = new hkbEventProperty();
            m_event.Read(des,br);
            m_minDistance = br.ReadSingle();
            m_maxDistance = br.ReadSingle();
            m_ignoreHandle = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_event.Write(s, bw);
            bw.WriteSingle(m_minDistance);
            bw.WriteSingle(m_maxDistance);
            bw.WriteBoolean(m_ignoreHandle);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

