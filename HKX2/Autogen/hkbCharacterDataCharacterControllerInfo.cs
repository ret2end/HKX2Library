using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterDataCharacterControllerInfo Signatire: 0xa0f415bf size: 24 flags: FLAGS_NONE

    // m_capsuleHeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_capsuleRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_characterControllerCinfo m_class: hkpCharacterControllerCinfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbCharacterDataCharacterControllerInfo : IHavokObject
    {

        public float m_capsuleHeight;
        public float m_capsuleRadius;
        public uint m_collisionFilterInfo;
        public hkpCharacterControllerCinfo /*pointer struct*/ m_characterControllerCinfo;

        public uint Signature => 0xa0f415bf;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_capsuleHeight = br.ReadSingle();
            m_capsuleRadius = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            br.Position += 4;
            m_characterControllerCinfo = des.ReadClassPointer<hkpCharacterControllerCinfo>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_capsuleHeight);
            bw.WriteSingle(m_capsuleRadius);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_characterControllerCinfo);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

