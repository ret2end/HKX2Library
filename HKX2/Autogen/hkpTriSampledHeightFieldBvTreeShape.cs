using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTriSampledHeightFieldBvTreeShape Signatire: 0x58e1e585 size: 80 flags: FLAGS_NONE

    // m_childContainer m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_childSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_wantAabbRejectionTest m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_padding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 12 offset: 61 flags:  enum: 
    
    public class hkpTriSampledHeightFieldBvTreeShape : hkpBvTreeShape
    {

        public hkpSingleShapeContainer/*struct void*/ m_childContainer;
        public int m_childSize;
        public bool m_wantAabbRejectionTest;
        public List<byte> m_padding;

        public override uint Signature => 0x58e1e585;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_childContainer = new hkpSingleShapeContainer();
            m_childContainer.Read(des,br);
            m_childSize = br.ReadInt32();
            m_wantAabbRejectionTest = br.ReadBoolean();
            m_padding = des.ReadByteCStyleArray(br, 12); //m_padding = br.ReadByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_childContainer.Write(s, bw);
            bw.WriteInt32(m_childSize);
            bw.WriteBoolean(m_wantAabbRejectionTest);
            s.WriteByteCStyleArray(bw, m_padding); //bw.WriteByte(m_padding);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

