using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpStorageSampledHeightFieldShape Signatire: 0x15ff414b size: 144 flags: FLAGS_NONE

    // m_storage m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 112 flags:  enum: 
    // m_triangleFlip m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    
    public class hkpStorageSampledHeightFieldShape : hkpSampledHeightFieldShape
    {

        public List<float> m_storage;
        public bool m_triangleFlip;

        public override uint Signature => 0x15ff414b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_storage = des.ReadSingleArray(br);
            m_triangleFlip = br.ReadBoolean();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSingleArray(bw, m_storage);
            bw.WriteBoolean(m_triangleFlip);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

