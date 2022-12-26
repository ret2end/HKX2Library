using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaAnimationPreviewColorContainer Signatire: 0x4bc4c3e0 size: 32 flags: FLAGS_NONE

    // m_previewColor m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkaAnimationPreviewColorContainer : hkReferencedObject
    {

        public List<uint> m_previewColor;

        public override uint Signature => 0x4bc4c3e0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_previewColor = des.ReadUInt32Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_previewColor);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

