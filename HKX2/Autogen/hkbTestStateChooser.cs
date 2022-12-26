using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTestStateChooser Signatire: 0xc0fcc436 size: 32 flags: FLAGS_NONE

    // m_int m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_real m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_string m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbTestStateChooser : hkbStateChooser
    {

        public int m_int;
        public float m_real;
        public string m_string;

        public override uint Signature => 0xc0fcc436;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_int = br.ReadInt32();
            m_real = br.ReadSingle();
            m_string = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_int);
            bw.WriteSingle(m_real);
            s.WriteStringPointer(bw, m_string);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

