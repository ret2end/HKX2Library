using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbPoseMatchingGeneratorInternalState Signatire: 0x552d9dd4 size: 40 flags: FLAGS_NONE

    // m_currentMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_bestMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_timeSinceBetterMatch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_error m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_resetCurrentMatchLocalTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkbPoseMatchingGeneratorInternalState : hkReferencedObject
    {

        public int m_currentMatch;
        public int m_bestMatch;
        public float m_timeSinceBetterMatch;
        public float m_error;
        public bool m_resetCurrentMatchLocalTime;

        public override uint Signature => 0x552d9dd4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_currentMatch = br.ReadInt32();
            m_bestMatch = br.ReadInt32();
            m_timeSinceBetterMatch = br.ReadSingle();
            m_error = br.ReadSingle();
            m_resetCurrentMatchLocalTime = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_currentMatch);
            bw.WriteInt32(m_bestMatch);
            bw.WriteSingle(m_timeSinceBetterMatch);
            bw.WriteSingle(m_error);
            bw.WriteBoolean(m_resetCurrentMatchLocalTime);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

