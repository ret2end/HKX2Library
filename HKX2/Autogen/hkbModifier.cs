using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbModifier Signatire: 0x96ec5ced size: 80 flags: FLAGS_NONE

    // m_enable m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_padModifier m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 3 offset: 73 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class hkbModifier : hkbNode
    {

        public bool m_enable;
        public List<bool> m_padModifier;

        public override uint Signature => 0x96ec5ced;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_enable = br.ReadBoolean();
            m_padModifier = des.ReadBooleanCStyleArray(br, 3);//m_padModifier = br.ReadBoolean();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_enable);
            s.WriteBooleanCStyleArray(bw, m_padModifier);//bw.WriteBoolean(m_padModifier);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

