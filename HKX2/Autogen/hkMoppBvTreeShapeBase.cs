using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkMoppBvTreeShapeBase Signatire: 0x7c338c66 size: 80 flags: FLAGS_NONE

    // m_code m_class: hkpMoppCode Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_moppData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_moppDataSize m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_codeInfoCopy m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkMoppBvTreeShapeBase : hkpBvTreeShape
    {

        public hkpMoppCode /*pointer struct*/ m_code;
        public dynamic /* POINTER VOID */ m_moppData;
        public uint m_moppDataSize;
        public Vector4 m_codeInfoCopy;

        public override uint Signature => 0x7c338c66;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_code = des.ReadClassPointer<hkpMoppCode>(br);
            des.ReadEmptyPointer(br);/* m_moppData POINTER VOID */
            m_moppDataSize = br.ReadUInt32();
            br.Position += 4;
            m_codeInfoCopy = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_code);
            s.WriteVoidPointer(bw);/* m_moppData POINTER VOID */
            bw.WriteUInt32(m_moppDataSize);
            bw.Position += 4;
            bw.WriteVector4(m_codeInfoCopy);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

