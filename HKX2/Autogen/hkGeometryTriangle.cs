using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkGeometryTriangle Signatire: 0x9687513b size: 16 flags: FLAGS_NONE

    // m_a m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_b m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_c m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_material m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkGeometryTriangle : IHavokObject
    {

        public int m_a;
        public int m_b;
        public int m_c;
        public int m_material;

        public uint Signature => 0x9687513b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_a = br.ReadInt32();
            m_b = br.ReadInt32();
            m_c = br.ReadInt32();
            m_material = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_a);
            bw.WriteInt32(m_b);
            bw.WriteInt32(m_c);
            bw.WriteInt32(m_material);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

