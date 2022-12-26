using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCollisionFilter Signatire: 0x60960336 size: 72 flags: FLAGS_NONE

    // m_prepad m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 2 offset: 48 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT32 arrSize: 0 offset: 56 flags:  enum: hkpFilterType
    // m_postpad m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 60 flags:  enum: 
    
    public class hkpCollisionFilter : hkReferencedObject
    {

        public List<uint> m_prepad;
        public uint m_type;
        public List<uint> m_postpad;

        public override uint Signature => 0x60960336;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 32;
            m_prepad = des.ReadUInt32CStyleArray(br, 2);//m_prepad = br.ReadUInt32();
            m_type = br.ReadUInt32();
            m_postpad = des.ReadUInt32CStyleArray(br, 3);//m_postpad = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 32;
            s.WriteUInt32CStyleArray(bw, m_prepad);//bw.WriteUInt32(m_prepad);
            s.WriteUInt32(bw, m_type);
            s.WriteUInt32CStyleArray(bw, m_postpad);//bw.WriteUInt32(m_postpad);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

