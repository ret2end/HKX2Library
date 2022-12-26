using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxAnimatedMatrix Signatire: 0x5838e337 size: 40 flags: FLAGS_NONE

    // m_matrices m_class:  Type.TYPE_ARRAY Type.TYPE_MATRIX4 arrSize: 0 offset: 16 flags:  enum: 
    // m_hint m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: Hint
    
    public class hkxAnimatedMatrix : hkReferencedObject
    {

        public List<Matrix4x4> m_matrices;
        public byte m_hint;

        public override uint Signature => 0x5838e337;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_matrices = des.ReadMatrix4Array(br);
            m_hint = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteMatrix4Array(bw, m_matrices);
            s.WriteByte(bw, m_hint);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

