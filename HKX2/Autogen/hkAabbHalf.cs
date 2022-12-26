using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkAabbHalf Signatire: 0x1d716a17 size: 16 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 6 offset: 0 flags:  enum: 
    // m_extras m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 2 offset: 12 flags:  enum: 
    
    public class hkAabbHalf : IHavokObject
    {

        public List<ushort> m_data;
        public List<ushort> m_extras;

        public uint Signature => 0x1d716a17;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            //m_data = br.ReadUInt16();
            //m_extras = br.ReadUInt16();
            m_data = des.ReadUInt16CStyleArray(br, 6);
            m_extras = des.ReadUInt16CStyleArray(br, 2);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            //bw.WriteUInt16(m_data);
            //bw.WriteUInt16(m_extras);
            s.WriteUInt16CStyleArray(bw, m_data);
            s.WriteUInt16CStyleArray(bw, m_extras);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

