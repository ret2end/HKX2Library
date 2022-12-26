using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCompressedSampledHeightFieldShape Signatire: 0x97b6e143 size: 144 flags: FLAGS_NONE

    // m_storage m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 112 flags:  enum: 
    // m_triangleFlip m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_offset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    // m_scale m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags:  enum: 
    
    public class hkpCompressedSampledHeightFieldShape : hkpSampledHeightFieldShape
    {

        public List<ushort> m_storage;
        public bool m_triangleFlip;
        public float m_offset;
        public float m_scale;

        public override uint Signature => 0x97b6e143;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_storage = des.ReadUInt16Array(br);
            m_triangleFlip = br.ReadBoolean();
            br.Position += 3;
            m_offset = br.ReadSingle();
            m_scale = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_storage);
            bw.WriteBoolean(m_triangleFlip);
            bw.Position += 3;
            bw.WriteSingle(m_offset);
            bw.WriteSingle(m_scale);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

