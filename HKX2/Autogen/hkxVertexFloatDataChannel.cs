using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexFloatDataChannel Signatire: 0xbeeb397c size: 40 flags: FLAGS_NONE

    // m_perVertexFloats m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags:  enum: 
    // m_dimensions m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: VertexFloatDimensions
    
    public class hkxVertexFloatDataChannel : hkReferencedObject
    {

        public List<float> m_perVertexFloats;
        public byte m_dimensions;

        public override uint Signature => 0xbeeb397c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_perVertexFloats = des.ReadSingleArray(br);
            m_dimensions = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSingleArray(bw, m_perVertexFloats);
            s.WriteByte(bw, m_dimensions);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

