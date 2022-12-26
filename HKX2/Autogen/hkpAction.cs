using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAction Signatire: 0xbdf70a51 size: 48 flags: FLAGS_NONE

    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_island m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkpAction : hkReferencedObject
    {

        public dynamic /* POINTER VOID */ m_world;
        public dynamic /* POINTER VOID */ m_island;
        public ulong m_userData;
        public string m_name;

        public override uint Signature => 0xbdf70a51;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_world POINTER VOID */
            des.ReadEmptyPointer(br);/* m_island POINTER VOID */
            m_userData = br.ReadUInt64();
            m_name = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_world POINTER VOID */
            s.WriteVoidPointer(bw);/* m_island POINTER VOID */
            bw.WriteUInt64(m_userData);
            s.WriteStringPointer(bw, m_name);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

