using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSBoneSwitchGenerator Signatire: 0xf33d3eea size: 112 flags: FLAGS_NONE

    // m_pDefaultGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_ChildrenA m_class: BSBoneSwitchGeneratorBoneData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 88 flags:  enum: 
    
    public class BSBoneSwitchGenerator : hkbGenerator
    {

        public hkbGenerator /*pointer struct*/ m_pDefaultGenerator;
        public List<BSBoneSwitchGeneratorBoneData> m_ChildrenA;

        public override uint Signature => 0xf33d3eea;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_pDefaultGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_ChildrenA = des.ReadClassPointerArray<BSBoneSwitchGeneratorBoneData>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pDefaultGenerator);
            s.WriteClassPointerArray<BSBoneSwitchGeneratorBoneData>(bw, m_ChildrenA);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

