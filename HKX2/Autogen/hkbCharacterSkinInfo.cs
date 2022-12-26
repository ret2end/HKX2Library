using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterSkinInfo Signatire: 0x180d900d size: 56 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_deformableSkins m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 24 flags:  enum: 
    // m_rigidSkins m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkbCharacterSkinInfo : hkReferencedObject
    {

        public ulong m_characterId;
        public List<ulong> m_deformableSkins;
        public List<ulong> m_rigidSkins;

        public override uint Signature => 0x180d900d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_deformableSkins = des.ReadUInt64Array(br);
            m_rigidSkins = des.ReadUInt64Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteUInt64Array(bw, m_deformableSkins);
            s.WriteUInt64Array(bw, m_rigidSkins);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

