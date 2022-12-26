using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSphereShape Signatire: 0x795d9fa size: 56 flags: FLAGS_NONE

    // m_pad16 m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 40 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class hkpSphereShape : hkpConvexShape
    {

        public List<uint> m_pad16;

        public override uint Signature => 0x795d9fa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_pad16 = des.ReadUInt32CStyleArray(br, 3); //m_pad16 = br.ReadUInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteUInt32CStyleArray(bw, m_pad16); //bw.WriteUInt32(m_pad16);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

