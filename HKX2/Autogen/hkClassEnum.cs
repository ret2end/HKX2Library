using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkClassEnum Signatire: 0x8a3609cf size: 40 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_items m_class: hkClassEnumItem Type.TYPE_SIMPLEARRAY Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    // m_attributes m_class: hkCustomAttributes Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT32 arrSize: 0 offset: 32 flags:  enum: FlagValues

    public class hkClassEnum : IHavokObject
    {

        public string m_name;
        public dynamic /*simpleArray struct*/ m_items;
        public hkCustomAttributes /*pointer struct*/ m_attributes;
        public uint m_flags;

        public uint Signature => 0x8a3609cf;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);//m_name = br.ReadASCII();
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            m_attributes = des.ReadClassPointer<hkCustomAttributes>(br);
            m_flags = br.ReadUInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);//bw.WriteASCII(m_name, true);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            s.WriteClassPointer(bw, m_attributes);
            bw.WriteUInt32(m_flags);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

