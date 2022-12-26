using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbClipTrigger Signatire: 0x7eb45cea size: 32 flags: FLAGS_NONE

    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_event m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_relativeToEndOfClip m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_acyclic m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 25 flags:  enum: 
    // m_isAnnotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 26 flags:  enum: 
    
    public class hkbClipTrigger : IHavokObject
    {

        public float m_localTime;
        public hkbEventProperty/*struct void*/ m_event;
        public bool m_relativeToEndOfClip;
        public bool m_acyclic;
        public bool m_isAnnotation;

        public uint Signature => 0x7eb45cea;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_localTime = br.ReadSingle();
            br.Position += 4;
            m_event = new hkbEventProperty();
            m_event.Read(des,br);
            m_relativeToEndOfClip = br.ReadBoolean();
            m_acyclic = br.ReadBoolean();
            m_isAnnotation = br.ReadBoolean();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_localTime);
            bw.Position += 4;
            m_event.Write(s, bw);
            bw.WriteBoolean(m_relativeToEndOfClip);
            bw.WriteBoolean(m_acyclic);
            bw.WriteBoolean(m_isAnnotation);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

