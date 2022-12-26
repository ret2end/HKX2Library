using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSModifyOnceModifier Signatire: 0x1e20a97a size: 112 flags: FLAGS_NONE

    // m_pOnActivateModifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_pOnDeactivateModifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class BSModifyOnceModifier : hkbModifier
    {

        public hkbModifier /*pointer struct*/ m_pOnActivateModifier;
        public hkbModifier /*pointer struct*/ m_pOnDeactivateModifier;

        public override uint Signature => 0x1e20a97a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_pOnActivateModifier = des.ReadClassPointer<hkbModifier>(br);
            br.Position += 8;
            m_pOnDeactivateModifier = des.ReadClassPointer<hkbModifier>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_pOnActivateModifier);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pOnDeactivateModifier);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

