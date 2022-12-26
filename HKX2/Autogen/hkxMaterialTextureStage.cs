using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxMaterialTextureStage Signatire: 0xfa6facb2 size: 16 flags: FLAGS_NONE

    // m_texture m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_usageHint m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 8 flags:  enum: TextureType
    // m_tcoordChannel m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkxMaterialTextureStage : IHavokObject
    {

        public hkReferencedObject /*pointer struct*/ m_texture;
        public int m_usageHint;
        public int m_tcoordChannel;

        public uint Signature => 0xfa6facb2;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_texture = des.ReadClassPointer<hkReferencedObject>(br);
            m_usageHint = br.ReadInt32();
            m_tcoordChannel = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_texture);
            s.WriteInt32(bw, m_usageHint);
            bw.WriteInt32(m_tcoordChannel);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

