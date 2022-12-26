using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaFootstepAnalysisInfoContainer Signatire: 0x1d81207c size: 32 flags: FLAGS_NONE

    // m_previewInfo m_class: hkaFootstepAnalysisInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkaFootstepAnalysisInfoContainer : hkReferencedObject
    {

        public List<hkaFootstepAnalysisInfo> m_previewInfo;

        public override uint Signature => 0x1d81207c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_previewInfo = des.ReadClassPointerArray<hkaFootstepAnalysisInfo>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkaFootstepAnalysisInfo>(bw, m_previewInfo);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

