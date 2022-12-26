using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaQuantizedAnimation Signatire: 0x3920f053 size: 88 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 56 flags:  enum: 
    // m_endian m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_skeleton m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 80 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkaQuantizedAnimation : hkaAnimation
    {

        public List<byte> m_data;
        public uint m_endian;
        public dynamic /* POINTER VOID */ m_skeleton;

        public override uint Signature => 0x3920f053;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_data = des.ReadByteArray(br);
            m_endian = br.ReadUInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_skeleton POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByteArray(bw, m_data);
            bw.WriteUInt32(m_endian);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_skeleton POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

