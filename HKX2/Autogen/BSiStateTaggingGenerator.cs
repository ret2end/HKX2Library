using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSiStateTaggingGenerator Signatire: 0xf0826fc1 size: 96 flags: FLAGS_NONE

    // m_pDefaultGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_iStateToSetAs m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_iPriority m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    
    public class BSiStateTaggingGenerator : hkbGenerator
    {

        public hkbGenerator /*pointer struct*/ m_pDefaultGenerator;
        public int m_iStateToSetAs;
        public int m_iPriority;

        public override uint Signature => 0xf0826fc1;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_pDefaultGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_iStateToSetAs = br.ReadInt32();
            m_iPriority = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pDefaultGenerator);
            bw.WriteInt32(m_iStateToSetAs);
            bw.WriteInt32(m_iPriority);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

