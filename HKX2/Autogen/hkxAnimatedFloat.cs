using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxAnimatedFloat Signatire: 0xce8b2fbd size: 40 flags: FLAGS_NONE

    // m_floats m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags:  enum: 
    // m_hint m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: Hint
    
    public class hkxAnimatedFloat : hkReferencedObject
    {

        public List<float> m_floats;
        public byte m_hint;

        public override uint Signature => 0xce8b2fbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_floats = des.ReadSingleArray(br);
            m_hint = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSingleArray(bw, m_floats);
            s.WriteByte(bw, m_hint);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

